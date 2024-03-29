﻿// *****************************************************************************
// 
//  © Component Factory Pty Ltd, 2006 - 2016. All rights reserved.
//	The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, PO Box 1504, 
//  Glen Waverley, Vic 3150, Australia and are supplied subject to licence terms.
// 
//  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV) 2017 - 2020. All rights reserved. (https://github.com/Wagnerp/Krypton-NET-5.462)
//  Version 5.462.0.0  www.ComponentFactory.com
//
// *****************************************************************************

using System;
using System.Windows.Forms;

using ComponentFactory.Krypton.Docking;
using ComponentFactory.Krypton.Navigator;
using ComponentFactory.Krypton.Toolkit;

namespace DockingFlags
{
    public partial class Form1 : KryptonForm
    {
        private int _count = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private KryptonPage NewDocument()
        {
            // Create new page with title and image
            KryptonPage p = new KryptonPage
            {
                Text = "Document " + _count.ToString()
            };
            p.TextTitle = p.Text;
            p.TextDescription = p.Text;
            p.UniqueName = p.Text;
            p.ImageSmall = imageListSmall.Images[0];

            // Add the control for display inside the page
            ContentDocument contentDoc = new ContentDocument
            {
                Dock = DockStyle.Fill
            };
            p.Controls.Add(contentDoc);

            _count++;
            return p;
        }

        private KryptonPage NewFlags()
        {
            // Create new page with title and image
            KryptonPage p = new KryptonPage
            {
                Text = "Flags " + _count.ToString()
            };
            p.TextTitle = p.Text;
            p.TextDescription = p.Text;
            p.UniqueName = p.Text;
            p.ImageSmall = imageListSmall.Images[1];

            // Add the control for display inside the page
            ContentFlags contentFlags = new ContentFlags(p)
            {
                Dock = DockStyle.Fill
            };
            p.Controls.Add(contentFlags);

            _count++;
            return p;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Setup docking functionality
            KryptonDockingWorkspace w = kryptonDockingManager.ManageWorkspace(kryptonDockableWorkspace);
            kryptonDockingManager.ManageControl(kryptonPanel, w);
            kryptonDockingManager.ManageFloating(this);

            // Add docking pages
            kryptonDockingManager.AddDockspace("Control", DockingEdge.Left, new KryptonPage[] { NewFlags(), NewFlags() });
            kryptonDockingManager.AddDockspace("Control", DockingEdge.Bottom, new KryptonPage[] { NewDocument() });
            kryptonDockingManager.AddToWorkspace("Workspace", new KryptonPage[] { NewFlags(), NewFlags() });
        }
    }
}
