﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using Acn.Rdm;
using RdmSnoop.Models;
using RdmSnoop.Transports;
using Acn.Slp;
using System.Net.NetworkInformation;
using System.Collections.ObjectModel;
using Acn.Sockets;

namespace RdmSnoop
{
    public partial class SnoopMain : Form
    {
        public SnoopMain()
        {
            InitializeComponent();

            packetView.Columns.Add("Time", 100);
            packetView.Columns.Add("Parameter", 200);
            packetView.Columns.Add("Command",90);
            packetView.Columns.Add("Source Id",150);
            packetView.Columns.Add("Target Id",150);            
            packetView.Columns.Add("IP Address",150);

            
            foreach (NetworkInterface adapter in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (adapter.SupportsMulticast)
                {
                    IPInterfaceProperties ipProperties = adapter.GetIPProperties();

                    for (int n = 0; n < ipProperties.UnicastAddresses.Count; n++)
                    {
                        if(ipProperties.UnicastAddresses[n].Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                        {
                            CardInfo card = new CardInfo(adapter, n);
                            networkCardSelect.Items.Add(card);
                        }
                    }
                }
            }

            networkCardSelect.SelectedIndex = 1;
        }

        private CardInfo selectedNetworkAdapter = null;

        public CardInfo SelectedNetworkAdapter
        {
            get { return selectedNetworkAdapter; }
            set 
            {
                if (selectedNetworkAdapter != value)
                {
                    selectedNetworkAdapter = value;

                    if (selectedNetworkAdapter != null && Transport != null)
                    {
                        StopTransport();
                        StartTransport();
                    }
                }
            }
        }

        private IRdmTransport transport = null;

        public IRdmTransport Transport
        {
            get { return transport; }
            set 
            {
                if (transport != value)
                {
                    transport = value;

                    if (transport != null)
                    {
                        transport.NewDeviceFound += new EventHandler<DeviceFoundEventArgs>(transport_NewDeviceFound);
                    }
                }
                
            }
        }

        void transport_NewRdmPacket(object sender, NewPacketEventArgs<RdmPacket> e)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new EventHandler<NewPacketEventArgs<RdmPacket>>(transport_NewRdmPacket),sender,e);
                return;
            }

            DateTime timeStamp = DateTime.Now;

            ListViewItem newItem = new ListViewItem(string.Format("{0}{1}",timeStamp.ToLongTimeString(),timeStamp.Millisecond.ToString()));
            newItem.SubItems.Add(e.Packet.Header.ParameterId.ToString());
            newItem.SubItems.Add(e.Packet.Header.Command.ToString());
            newItem.SubItems.Add(e.Packet.Header.SourceId.ToString());
            newItem.SubItems.Add(e.Packet.Header.DestinationId.ToString());            
            newItem.SubItems.Add(e.Source.Address.ToString());
            
            packetView.Items.Add(newItem);
        }

        private void StopTransport()
        {
            Transport.Stop();
            rdmDevices.Nodes.Clear();
            devices.Clear();
            packetView.Items.Clear();
        }

        private void StartTransport()
        {
            Transport.Start(SelectedNetworkAdapter.IpAddress, selectedNetworkAdapter.SubnetMask);

            foreach (IRdmSocket socket in Transport.Sockets)
            {
                socket.NewRdmPacket += transport_NewRdmPacket;
                socket.RdmPacketSent += transport_NewRdmPacket;
            }
        }

        void transport_NewDeviceFound(object sender, DeviceFoundEventArgs e)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new EventHandler<DeviceFoundEventArgs>(transport_NewDeviceFound), sender, e);
                return;
            }

            AddDevice(e.Id, e.IpAddress);
        }


        private Dictionary<UId, RdmDeviceModel> devices = new Dictionary<UId, RdmDeviceModel>();

        private void AddDevice(UId id, RdmAddress address)
        {
            if (!devices.ContainsKey(id))
            {
                RdmDeviceModel device = new RdmDeviceModel(new TreeNode(id.ToString()), Transport.GetDeviceSocket(id), id, address);
                devices[id] = device;
                rdmDevices.Nodes.Add(device.Node);

                device.Interogate();
            }
        }

        private void rdmNetSelect_Click(object sender, EventArgs e)
        {
            if (!(Transport is RdmNet))
            {
                StopTransport();
                Transport = new RdmNet();
                StartTransport();
                
            }

            rdmNetSelect.Checked = true;
            artNetSelect.Checked = false;
        }

        private void artNetSelect_Click(object sender, EventArgs e)
        {
            if (!(Transport is ArtNet))
            {
                StopTransport();
                Transport = new ArtNet();
                StartTransport();
            }

            rdmNetSelect.Checked = false;
            artNetSelect.Checked = true;
        }

        private void networkCardSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedNetworkAdapter = networkCardSelect.SelectedItem as CardInfo;

            
        }

        private void discoverSelect_Click(object sender, EventArgs e)
        {
            Transport.Discover();
        }

        private void SnoopMain_Load(object sender, EventArgs e)
        {
            Transport = new RdmNet();
        }

        private void rdmDevices_AfterSelect(object sender, TreeViewEventArgs e)
        {
            RdmDeviceModel model = e.Node.Tag as RdmDeviceModel;
            if (model != null)
            {
                deviceInformation.SelectedObject = model.Broker;
            }
        }

    }
}
