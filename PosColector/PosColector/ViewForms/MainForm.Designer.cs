using System.ComponentModel;
using System.Windows.Forms;

namespace PosColector.ViewForms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        private MainMenu mnuMain;

        private MenuItem mnuExit;

        private Label lblDateTimeNow;

        private Timer tmrNow;

        private MenuItem mnuStart;

        private MenuItem mnuPurchases;

        private MenuItem menuItem3;

        private MenuItem mnuSeparate1;

        private MenuItem mnuPurchaseOrder;

        private MenuItem mnuQueryByPedido;

        private MenuItem menuItem2;

        private MenuItem mnuSeparate2;

        private MenuItem mnuFreePurchase;

        private MenuItem mnuQueryFreePurchase;

        private MenuItem menuItem1;

        private MenuItem mnuInventory;

        private MenuItem mnuCaptureInventory;

        private MenuItem mnuQueryInventory;

        private MenuItem mnuSynchronization;

        private MenuItem mnuCatalogos;

        private MenuItem menuItem4;

        private MenuItem mnuDownload;

        private MenuItem mnuUpload;

        private MenuItem menuItem7;

        private MenuItem mnuDownloadInventory;

        private MenuItem mnuLoadInventory;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.mnuMain = new System.Windows.Forms.MainMenu();
			this.mnuStart = new System.Windows.Forms.MenuItem();
			this.mnuPurchases = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.mnuSeparate1 = new System.Windows.Forms.MenuItem();
			this.mnuPurchaseOrder = new System.Windows.Forms.MenuItem();
			this.mnuQueryByPedido = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.mnuSeparate2 = new System.Windows.Forms.MenuItem();
			this.mnuFreePurchase = new System.Windows.Forms.MenuItem();
			this.mnuQueryFreePurchase = new System.Windows.Forms.MenuItem();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.mnuInventory = new System.Windows.Forms.MenuItem();
			this.mnuCaptureInventory = new System.Windows.Forms.MenuItem();
			this.mnuQueryInventory = new System.Windows.Forms.MenuItem();
			this.mnuSynchronization = new System.Windows.Forms.MenuItem();
			this.mnuCatalogos = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.mnuDownload = new System.Windows.Forms.MenuItem();
			this.mnuUpload = new System.Windows.Forms.MenuItem();
			this.menuItem7 = new System.Windows.Forms.MenuItem();
			this.mnuDownloadInventory = new System.Windows.Forms.MenuItem();
			this.mnuLoadInventory = new System.Windows.Forms.MenuItem();
			this.mnuExit = new System.Windows.Forms.MenuItem();
			this.lblDateTimeNow = new System.Windows.Forms.Label();
			this.tmrNow = new System.Windows.Forms.Timer();
			base.SuspendLayout();
			this.mnuMain.MenuItems.Add(this.mnuStart);
			this.mnuMain.MenuItems.Add(this.mnuExit);
			this.mnuStart.MenuItems.Add(this.mnuPurchases);
			this.mnuStart.MenuItems.Add(this.mnuInventory);
			this.mnuStart.MenuItems.Add(this.mnuSynchronization);
			this.mnuStart.Text = "Inicio";
			this.mnuPurchases.MenuItems.Add(this.menuItem3);
			this.mnuPurchases.MenuItems.Add(this.mnuSeparate1);
			this.mnuPurchases.MenuItems.Add(this.mnuPurchaseOrder);
			this.mnuPurchases.MenuItems.Add(this.mnuQueryByPedido);
			this.mnuPurchases.MenuItems.Add(this.menuItem2);
			this.mnuPurchases.MenuItems.Add(this.mnuSeparate2);
			this.mnuPurchases.MenuItems.Add(this.mnuFreePurchase);
			this.mnuPurchases.MenuItems.Add(this.mnuQueryFreePurchase);
			this.mnuPurchases.MenuItems.Add(this.menuItem1);
			this.mnuPurchases.Text = "Compras";
			this.menuItem3.Text = "-";
			this.mnuSeparate1.Enabled = false;
			this.mnuSeparate1.Text = "-- POR PEDIDO --";
			this.mnuPurchaseOrder.Text = "Capturar";
			this.mnuPurchaseOrder.Click += new System.EventHandler(mnuPurchaseOrder_Click);
			this.mnuQueryByPedido.Text = "Consultar";
			this.mnuQueryByPedido.Click += new System.EventHandler(mnuQueryByPedido_Click);
			this.menuItem2.Text = "-";
			this.mnuSeparate2.Enabled = false;
			this.mnuSeparate2.Text = "-- ABIERTA --";
			this.mnuFreePurchase.Text = "Capturar";
			this.mnuFreePurchase.Click += new System.EventHandler(mnuFreePurchase_Click);
			this.mnuQueryFreePurchase.Text = "Consultar";
			this.mnuQueryFreePurchase.Click += new System.EventHandler(mnuQueryFreePurchase_Click);
			this.menuItem1.Text = "-";
			this.mnuInventory.MenuItems.Add(this.mnuCaptureInventory);
			this.mnuInventory.MenuItems.Add(this.mnuQueryInventory);
			this.mnuInventory.Text = "Inventario";
			this.mnuCaptureInventory.Text = "Capturar";
			this.mnuCaptureInventory.Click += new System.EventHandler(mnuCaptureInventory_Click);
			this.mnuQueryInventory.Text = "Consultar";
			this.mnuQueryInventory.Click += new System.EventHandler(mnuQueryInventory_Click);
			this.mnuSynchronization.MenuItems.Add(this.mnuCatalogos);
			this.mnuSynchronization.MenuItems.Add(this.menuItem4);
			this.mnuSynchronization.MenuItems.Add(this.mnuDownload);
			this.mnuSynchronization.MenuItems.Add(this.mnuUpload);
			this.mnuSynchronization.MenuItems.Add(this.menuItem7);
			this.mnuSynchronization.MenuItems.Add(this.mnuDownloadInventory);
			this.mnuSynchronization.MenuItems.Add(this.mnuLoadInventory);
			this.mnuSynchronization.Text = "Sincronizar";
			this.mnuCatalogos.Text = "Catálogos Principales";
			this.mnuCatalogos.Click += new System.EventHandler(mnuCatalogos_Click_1);
			this.menuItem4.Text = "-";
			this.mnuDownload.Text = "Pedidos";
			this.mnuDownload.Click += new System.EventHandler(mnuDownload_Click);
			this.mnuUpload.Text = "Compras";
			this.mnuUpload.Click += new System.EventHandler(mnuUpload_Click);
			this.menuItem7.Text = "-";
			this.mnuDownloadInventory.Text = "Inventarios Abiertos";
			this.mnuDownloadInventory.Click += new System.EventHandler(mnuSyncInventory_Click);
			this.mnuLoadInventory.Text = "Inventarios Realizados";
			this.mnuLoadInventory.Click += new System.EventHandler(mnuLoadInventory_Click);
			this.mnuExit.Text = "Salir";
			this.mnuExit.Click += new System.EventHandler(mnuExit_Click);
			this.lblDateTimeNow.Font = new System.Drawing.Font("Tahoma", 10f, System.Drawing.FontStyle.Bold);
			this.lblDateTimeNow.Location = new System.Drawing.Point(3, 221);
			this.lblDateTimeNow.Name = "lblDateTimeNow";
			this.lblDateTimeNow.Size = new System.Drawing.Size(232, 20);
			this.lblDateTimeNow.Text = "01/01/2016 01:00:00";
			this.lblDateTimeNow.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.tmrNow.Enabled = true;
			this.tmrNow.Interval = 1000;
			this.tmrNow.Tick += new System.EventHandler(tmrNow_Tick);
			base.AutoScaleDimensions = new System.Drawing.SizeF(96f, 96f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.AutoScroll = true;
			((System.Windows.Forms.Control)this).ClientSize = new System.Drawing.Size(638, 455);
			base.Controls.Add(this.lblDateTimeNow);
			base.MaximizeBox = false;
			base.Menu = this.mnuMain;
			base.MinimizeBox = false;
			base.Name = "MainForm";
			this.Text = "POS Colector v3.5 :: Su Plaza de Actopan";
			base.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			base.Closing += new System.ComponentModel.CancelEventHandler(MainForm_Closing);
			base.ResumeLayout(false);
		}

		#endregion
	}
}