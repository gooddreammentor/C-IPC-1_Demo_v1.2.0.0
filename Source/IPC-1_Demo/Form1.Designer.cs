namespace DLLtester
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            this.labelRtnOpenCOM = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelDLLVer = new System.Windows.Forms.Label();
            this.textBoxCOMPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelRtnCloseCOM = new System.Windows.Forms.Label();
            this.buttonOpenCOM = new System.Windows.Forms.Button();
            this.buttonCloseCOM = new System.Windows.Forms.Button();
            this.labelRtnGetSerialNumber = new System.Windows.Forms.Label();
            this.labelGetSerialNumberString = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelRtnResetMDB = new System.Windows.Forms.Label();
            this.labelRtnPingIPC = new System.Windows.Forms.Label();
            this.labelGetKernelVersionString = new System.Windows.Forms.Label();
            this.labelRtnGetKernelVersion = new System.Windows.Forms.Label();
            this.buttonGetSerialNumber = new System.Windows.Forms.Button();
            this.labelGetMDBBillStatusString = new System.Windows.Forms.Label();
            this.labelRtnGetMDBBillStatus = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.buttonPingIPC = new System.Windows.Forms.Button();
            this.buttonGetKernelVersion = new System.Windows.Forms.Button();
            this.buttonResetMDB = new System.Windows.Forms.Button();
            this.buttonGetMDBBillStatus = new System.Windows.Forms.Button();
            this.timerAutoPoll = new System.Windows.Forms.Timer(this.components);
            this.checkBoxAutoBill = new System.Windows.Forms.CheckBox();
            this.checkBoxAutoCoin = new System.Windows.Forms.CheckBox();
            this.buttonGetMDBCoinStatus = new System.Windows.Forms.Button();
            this.labelGetMDBCoinStatusString = new System.Windows.Forms.Label();
            this.labelRtnGetMDBCoinStatus = new System.Windows.Forms.Label();
            this.labelRtnDispenseMDBCoinsByValue = new System.Windows.Forms.Label();
            this.labelRtnGetMDBCoinPayoutFinal = new System.Windows.Forms.Label();
            this.labelRtnSetMDBCoinChannels = new System.Windows.Forms.Label();
            this.buttonSetMDBCoinChannels = new System.Windows.Forms.Button();
            this.buttonGetMDBCoinPayoutFinal = new System.Windows.Forms.Button();
            this.buttonPollMDBCoinPayout = new System.Windows.Forms.Button();
            this.labelRtnPollMDBCoinPayout = new System.Windows.Forms.Label();
            this.labelCoinCh0 = new System.Windows.Forms.Label();
            this.labelCoinCh1 = new System.Windows.Forms.Label();
            this.labelCoinCh2 = new System.Windows.Forms.Label();
            this.labelCoinCh3 = new System.Windows.Forms.Label();
            this.labelCoinCh7 = new System.Windows.Forms.Label();
            this.labelCoinCh6 = new System.Windows.Forms.Label();
            this.labelCoinCh5 = new System.Windows.Forms.Label();
            this.labelCoinCh4 = new System.Windows.Forms.Label();
            this.labelCoinCh11 = new System.Windows.Forms.Label();
            this.labelCoinCh10 = new System.Windows.Forms.Label();
            this.labelCoinCh9 = new System.Windows.Forms.Label();
            this.labelCoinCh8 = new System.Windows.Forms.Label();
            this.labelCoinCh15 = new System.Windows.Forms.Label();
            this.labelCoinCh14 = new System.Windows.Forms.Label();
            this.labelCoinCh13 = new System.Windows.Forms.Label();
            this.labelCoinCh12 = new System.Windows.Forms.Label();
            this.labelCoinLevel = new System.Windows.Forms.Label();
            this.labelCoinScale = new System.Windows.Forms.Label();
            this.labelCoinDecimal = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.labelCoinISO = new System.Windows.Forms.Label();
            this.buttonGetMDBCoinSetup = new System.Windows.Forms.Button();
            this.labelMiscMDBCmdRepliedString = new System.Windows.Forms.Label();
            this.labelRtnGetMDBCoinSetup = new System.Windows.Forms.Label();
            this.checkBoxCoinEnable0 = new System.Windows.Forms.CheckBox();
            this.checkBoxCoinEnable1 = new System.Windows.Forms.CheckBox();
            this.checkBoxCoinEnable2 = new System.Windows.Forms.CheckBox();
            this.checkBoxCoinEnable3 = new System.Windows.Forms.CheckBox();
            this.checkBoxCoinEnable4 = new System.Windows.Forms.CheckBox();
            this.checkBoxCoinEnable5 = new System.Windows.Forms.CheckBox();
            this.checkBoxCoinEnable6 = new System.Windows.Forms.CheckBox();
            this.checkBoxCoinEnable7 = new System.Windows.Forms.CheckBox();
            this.checkBoxCoinEnable11 = new System.Windows.Forms.CheckBox();
            this.checkBoxCoinEnable10 = new System.Windows.Forms.CheckBox();
            this.checkBoxCoinEnable9 = new System.Windows.Forms.CheckBox();
            this.checkBoxCoinEnable8 = new System.Windows.Forms.CheckBox();
            this.checkBoxCoinEnable15 = new System.Windows.Forms.CheckBox();
            this.checkBoxCoinEnable14 = new System.Windows.Forms.CheckBox();
            this.checkBoxCoinEnable13 = new System.Windows.Forms.CheckBox();
            this.checkBoxCoinEnable12 = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageSetCoinEnable = new System.Windows.Forms.TabPage();
            this.label24 = new System.Windows.Forms.Label();
            this.tabPageCoinTubeContent = new System.Windows.Forms.TabPage();
            this.label25 = new System.Windows.Forms.Label();
            this.labelRtnGetMDBCoinTubeContent = new System.Windows.Forms.Label();
            this.buttonGetMDBCoinTubeContent = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.labelTube15 = new System.Windows.Forms.Label();
            this.labelTube14 = new System.Windows.Forms.Label();
            this.labelTube13 = new System.Windows.Forms.Label();
            this.labelTube12 = new System.Windows.Forms.Label();
            this.labelTube11 = new System.Windows.Forms.Label();
            this.labelTube10 = new System.Windows.Forms.Label();
            this.labelTube9 = new System.Windows.Forms.Label();
            this.labelTube8 = new System.Windows.Forms.Label();
            this.labelTube7 = new System.Windows.Forms.Label();
            this.labelTube6 = new System.Windows.Forms.Label();
            this.labelTube5 = new System.Windows.Forms.Label();
            this.labelTube4 = new System.Windows.Forms.Label();
            this.labelTube3 = new System.Windows.Forms.Label();
            this.labelTube2 = new System.Windows.Forms.Label();
            this.labelTube1 = new System.Windows.Forms.Label();
            this.labelTube0 = new System.Windows.Forms.Label();
            this.tabPageCoinPayoutFinal = new System.Windows.Forms.TabPage();
            this.label26 = new System.Windows.Forms.Label();
            this.labelGetMDBCoinPayoutFinalAckOnly = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.labelCoinPayoutFinal15 = new System.Windows.Forms.Label();
            this.labelCoinPayoutFinal14 = new System.Windows.Forms.Label();
            this.labelCoinPayoutFinal13 = new System.Windows.Forms.Label();
            this.labelCoinPayoutFinal12 = new System.Windows.Forms.Label();
            this.labelCoinPayoutFinal11 = new System.Windows.Forms.Label();
            this.labelCoinPayoutFinal10 = new System.Windows.Forms.Label();
            this.labelCoinPayoutFinal9 = new System.Windows.Forms.Label();
            this.labelCoinPayoutFinal8 = new System.Windows.Forms.Label();
            this.labelCoinPayoutFinal7 = new System.Windows.Forms.Label();
            this.labelCoinPayoutFinal6 = new System.Windows.Forms.Label();
            this.labelCoinPayoutFinal5 = new System.Windows.Forms.Label();
            this.labelCoinPayoutFinal4 = new System.Windows.Forms.Label();
            this.labelCoinPayoutFinal3 = new System.Windows.Forms.Label();
            this.labelCoinPayoutFinal2 = new System.Windows.Forms.Label();
            this.labelCoinPayoutFinal1 = new System.Windows.Forms.Label();
            this.labelCoinPayoutFinal0 = new System.Windows.Forms.Label();
            this.buttonDispenseMDBCoinsByValue = new System.Windows.Forms.Button();
            this.buttonDispenseMDBCoinsByType = new System.Windows.Forms.Button();
            this.labelRtnDispenseMDBCoinsByType = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.labelPollMDBCoinPayoutString = new System.Windows.Forms.Label();
            this.numericUpDownDispenseMDBCoinsByType1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDispenseMDBCoinsByType2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDispenseMDBCoinsByValue = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.labelCoinStatusLightBox_Idle = new System.Windows.Forms.Label();
            this.labelCoinStatusLightBox_Reset = new System.Windows.Forms.Label();
            this.labelCoinStatusLightBox_Disabled = new System.Windows.Forms.Label();
            this.labelCoinStatusLightBox_Cheated = new System.Windows.Forms.Label();
            this.labelCoinStatusLightBox_Credit = new System.Windows.Forms.Label();
            this.labelCoinStatusLightBox_Manual = new System.Windows.Forms.Label();
            this.labelCoinStatusLightBox_Jammed = new System.Windows.Forms.Label();
            this.labelCoinStatusLightBox_Failure = new System.Windows.Forms.Label();
            this.labelCoinStatusLightBox_NoComm = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.labelCoinStatusLightBox_CreditAmount = new System.Windows.Forms.Label();
            this.labelCoinStatusLightBox_ManualAmount = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.buttonClearCoinAmount = new System.Windows.Forms.Button();
            this.labelCoinStatusLightBox_Credit2CB = new System.Windows.Forms.Label();
            this.labelCoinStatusLightBox_Credit2TU = new System.Windows.Forms.Label();
            this.labelCoinStatusLightBox_Credit2RJ = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.labelBillStatusLightBox_Transferred = new System.Windows.Forms.Label();
            this.labelBillStatusLightBox_Credit2RE = new System.Windows.Forms.Label();
            this.labelBillStatusLightBox_Credit2CB = new System.Windows.Forms.Label();
            this.buttonClearBillAmount = new System.Windows.Forms.Button();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.labelBillStatusLightBox_ManualDispensedAmount = new System.Windows.Forms.Label();
            this.labelBillStatusLightBox_CreditAmount = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.labelBillStatusLightBox_NoComm = new System.Windows.Forms.Label();
            this.labelBillStatusLightBox_Failure = new System.Windows.Forms.Label();
            this.labelBillStatusLightBox_Jammed = new System.Windows.Forms.Label();
            this.labelBillStatusLightBox_ManualDispensed = new System.Windows.Forms.Label();
            this.labelBillStatusLightBox_Credit = new System.Windows.Forms.Label();
            this.labelBillStatusLightBox_Cheated = new System.Windows.Forms.Label();
            this.labelBillStatusLightBox_Disabled = new System.Windows.Forms.Label();
            this.labelBillStatusLightBox_Reset = new System.Windows.Forms.Label();
            this.labelBillStatusLightBox_Idle = new System.Windows.Forms.Label();
            this.buttonGetMDBBillSetup = new System.Windows.Forms.Button();
            this.labelRtnGetMDBBillSetup = new System.Windows.Forms.Label();
            this.labelBillISO = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.labelBillDecimal = new System.Windows.Forms.Label();
            this.labelBillScale = new System.Windows.Forms.Label();
            this.labelBillLevel = new System.Windows.Forms.Label();
            this.labelBillCh15 = new System.Windows.Forms.Label();
            this.labelBillCh14 = new System.Windows.Forms.Label();
            this.labelBillCh13 = new System.Windows.Forms.Label();
            this.labelBillCh12 = new System.Windows.Forms.Label();
            this.labelBillCh11 = new System.Windows.Forms.Label();
            this.labelBillCh10 = new System.Windows.Forms.Label();
            this.labelBillCh9 = new System.Windows.Forms.Label();
            this.labelBillCh8 = new System.Windows.Forms.Label();
            this.labelBillCh7 = new System.Windows.Forms.Label();
            this.labelBillCh6 = new System.Windows.Forms.Label();
            this.labelBillCh5 = new System.Windows.Forms.Label();
            this.labelBillCh4 = new System.Windows.Forms.Label();
            this.labelBillCh3 = new System.Windows.Forms.Label();
            this.labelBillCh2 = new System.Windows.Forms.Label();
            this.labelBillCh1 = new System.Windows.Forms.Label();
            this.labelBillCh0 = new System.Windows.Forms.Label();
            this.label83 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.numericUpDownDispenseMDBBillsByValue = new System.Windows.Forms.NumericUpDown();
            this.labelBillStatusLightBox_Rejected = new System.Windows.Forms.Label();
            this.labelBillStatusLightBox_Rejecting = new System.Windows.Forms.Label();
            this.labelBillStatusLightBox_Stacking = new System.Windows.Forms.Label();
            this.labelBillStatusLightBox_CassetteProblem = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.labelBillStatusLightBox_TransferredAmount = new System.Windows.Forms.Label();
            this.label71 = new System.Windows.Forms.Label();
            this.labelBillStatusLightBox_EscrowedAmount = new System.Windows.Forms.Label();
            this.labelBillStatusLightBox_Escrowed = new System.Windows.Forms.Label();
            this.labelBillStatusLightBox_InvalidEscrow = new System.Windows.Forms.Label();
            this.checkBoxMDBBillAutoAccept = new System.Windows.Forms.CheckBox();
            this.buttonMDBBillEscrowAccept = new System.Windows.Forms.Button();
            this.buttonMDBBillEscrowReturn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageGetRouteEnable = new System.Windows.Forms.TabControl();
            this.tabPageSetBillEnable = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonSetMDBBillChannels = new System.Windows.Forms.Button();
            this.checkBoxBillEnable15 = new System.Windows.Forms.CheckBox();
            this.checkBoxBillEnable14 = new System.Windows.Forms.CheckBox();
            this.labelRtnSetMDBBillChannels = new System.Windows.Forms.Label();
            this.checkBoxBillEnable13 = new System.Windows.Forms.CheckBox();
            this.checkBoxBillEnable12 = new System.Windows.Forms.CheckBox();
            this.checkBoxBillEnable0 = new System.Windows.Forms.CheckBox();
            this.checkBoxBillEnable11 = new System.Windows.Forms.CheckBox();
            this.checkBoxBillEnable1 = new System.Windows.Forms.CheckBox();
            this.checkBoxBillEnable10 = new System.Windows.Forms.CheckBox();
            this.checkBoxBillEnable2 = new System.Windows.Forms.CheckBox();
            this.checkBoxBillEnable9 = new System.Windows.Forms.CheckBox();
            this.checkBoxBillEnable3 = new System.Windows.Forms.CheckBox();
            this.checkBoxBillEnable8 = new System.Windows.Forms.CheckBox();
            this.checkBoxBillEnable4 = new System.Windows.Forms.CheckBox();
            this.checkBoxBillEnable7 = new System.Windows.Forms.CheckBox();
            this.checkBoxBillEnable5 = new System.Windows.Forms.CheckBox();
            this.checkBoxBillEnable6 = new System.Windows.Forms.CheckBox();
            this.tabPageGetBillRouteTable = new System.Windows.Forms.TabPage();
            this.label31 = new System.Windows.Forms.Label();
            this.labelRtnGetMDBRecyclerRouteTable = new System.Windows.Forms.Label();
            this.buttonGetMDBRecyclerRouteTable = new System.Windows.Forms.Button();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.labelRouteTable15 = new System.Windows.Forms.Label();
            this.labelRouteTable14 = new System.Windows.Forms.Label();
            this.labelRouteTable13 = new System.Windows.Forms.Label();
            this.labelRouteTable12 = new System.Windows.Forms.Label();
            this.labelRouteTable11 = new System.Windows.Forms.Label();
            this.labelRouteTable10 = new System.Windows.Forms.Label();
            this.labelRouteTable9 = new System.Windows.Forms.Label();
            this.labelRouteTable8 = new System.Windows.Forms.Label();
            this.labelRouteTable7 = new System.Windows.Forms.Label();
            this.labelRouteTable6 = new System.Windows.Forms.Label();
            this.labelRouteTable5 = new System.Windows.Forms.Label();
            this.labelRouteTable4 = new System.Windows.Forms.Label();
            this.labelRouteTable3 = new System.Windows.Forms.Label();
            this.labelRouteTable2 = new System.Windows.Forms.Label();
            this.labelRouteTable1 = new System.Windows.Forms.Label();
            this.labelRouteTable0 = new System.Windows.Forms.Label();
            this.tabPageSetBillRouteEnable = new System.Windows.Forms.TabPage();
            this.label78 = new System.Windows.Forms.Label();
            this.buttonSetMDBRecyclerRouteEnable = new System.Windows.Forms.Button();
            this.checkBoxRouteEnable15 = new System.Windows.Forms.CheckBox();
            this.checkBoxRouteEnable14 = new System.Windows.Forms.CheckBox();
            this.labelRtnSetMDBRecyclerRouteEnable = new System.Windows.Forms.Label();
            this.checkBoxRouteEnable13 = new System.Windows.Forms.CheckBox();
            this.checkBoxRouteEnable12 = new System.Windows.Forms.CheckBox();
            this.checkBoxRouteEnable0 = new System.Windows.Forms.CheckBox();
            this.checkBoxRouteEnable11 = new System.Windows.Forms.CheckBox();
            this.checkBoxRouteEnable1 = new System.Windows.Forms.CheckBox();
            this.checkBoxRouteEnable10 = new System.Windows.Forms.CheckBox();
            this.checkBoxRouteEnable2 = new System.Windows.Forms.CheckBox();
            this.checkBoxRouteEnable9 = new System.Windows.Forms.CheckBox();
            this.checkBoxRouteEnable3 = new System.Windows.Forms.CheckBox();
            this.checkBoxRouteEnable8 = new System.Windows.Forms.CheckBox();
            this.checkBoxRouteEnable4 = new System.Windows.Forms.CheckBox();
            this.checkBoxRouteEnable7 = new System.Windows.Forms.CheckBox();
            this.checkBoxRouteEnable5 = new System.Windows.Forms.CheckBox();
            this.checkBoxRouteEnable6 = new System.Windows.Forms.CheckBox();
            this.tabPageRecyclerContent = new System.Windows.Forms.TabPage();
            this.label82 = new System.Windows.Forms.Label();
            this.labelRtnGetMDBRecyclerContent = new System.Windows.Forms.Label();
            this.buttonGetMDBRecyclerContent = new System.Windows.Forms.Button();
            this.label85 = new System.Windows.Forms.Label();
            this.label86 = new System.Windows.Forms.Label();
            this.label87 = new System.Windows.Forms.Label();
            this.label88 = new System.Windows.Forms.Label();
            this.labelRecyclerContent15 = new System.Windows.Forms.Label();
            this.labelRecyclerContent14 = new System.Windows.Forms.Label();
            this.labelRecyclerContent13 = new System.Windows.Forms.Label();
            this.labelRecyclerContent12 = new System.Windows.Forms.Label();
            this.labelRecyclerContent11 = new System.Windows.Forms.Label();
            this.labelRecyclerContent10 = new System.Windows.Forms.Label();
            this.labelRecyclerContent9 = new System.Windows.Forms.Label();
            this.labelRecyclerContent8 = new System.Windows.Forms.Label();
            this.labelRecyclerContent7 = new System.Windows.Forms.Label();
            this.labelRecyclerContent6 = new System.Windows.Forms.Label();
            this.labelRecyclerContent5 = new System.Windows.Forms.Label();
            this.labelRecyclerContent4 = new System.Windows.Forms.Label();
            this.labelRecyclerContent3 = new System.Windows.Forms.Label();
            this.labelRecyclerContent2 = new System.Windows.Forms.Label();
            this.labelRecyclerContent1 = new System.Windows.Forms.Label();
            this.labelRecyclerContent0 = new System.Windows.Forms.Label();
            this.tabPageRecyclerPayoutFinal = new System.Windows.Forms.TabPage();
            this.label77 = new System.Windows.Forms.Label();
            this.labelGetMDBRecyclerPayoutFinalAckOnly = new System.Windows.Forms.Label();
            this.label80 = new System.Windows.Forms.Label();
            this.label81 = new System.Windows.Forms.Label();
            this.label84 = new System.Windows.Forms.Label();
            this.label102 = new System.Windows.Forms.Label();
            this.labelRecyclerPayoutFinal15 = new System.Windows.Forms.Label();
            this.labelRecyclerPayoutFinal14 = new System.Windows.Forms.Label();
            this.labelRecyclerPayoutFinal13 = new System.Windows.Forms.Label();
            this.labelRecyclerPayoutFinal12 = new System.Windows.Forms.Label();
            this.labelRecyclerPayoutFinal11 = new System.Windows.Forms.Label();
            this.labelRecyclerPayoutFinal10 = new System.Windows.Forms.Label();
            this.labelRecyclerPayoutFinal9 = new System.Windows.Forms.Label();
            this.labelRecyclerPayoutFinal8 = new System.Windows.Forms.Label();
            this.labelRecyclerPayoutFinal7 = new System.Windows.Forms.Label();
            this.labelRecyclerPayoutFinal6 = new System.Windows.Forms.Label();
            this.labelRecyclerPayoutFinal5 = new System.Windows.Forms.Label();
            this.labelRecyclerPayoutFinal4 = new System.Windows.Forms.Label();
            this.labelRecyclerPayoutFinal3 = new System.Windows.Forms.Label();
            this.labelRecyclerPayoutFinal2 = new System.Windows.Forms.Label();
            this.labelRecyclerPayoutFinal1 = new System.Windows.Forms.Label();
            this.labelRecyclerPayoutFinal0 = new System.Windows.Forms.Label();
            this.buttonGetMDBRecyclerPayoutFinal = new System.Windows.Forms.Button();
            this.labelRtnGetMDBRecyclerPayoutFinal = new System.Windows.Forms.Label();
            this.labelBillStatusLightBox_ManualFilled = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.labelBillStatusLightBox_ManualFilledAmount = new System.Windows.Forms.Label();
            this.label101 = new System.Windows.Forms.Label();
            this.labelBillStatusLightBox_FillButton = new System.Windows.Forms.Label();
            this.labelBillStatusLightBox_EscrowButton = new System.Windows.Forms.Label();
            this.labelBillStatusLightBox_RecyclerDisabled = new System.Windows.Forms.Label();
            this.labelCoinStatusLightBox_EscrowLever = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label110 = new System.Windows.Forms.Label();
            this.label111 = new System.Windows.Forms.Label();
            this.numericUpDownDispenseMDBBillsByType2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDispenseMDBBillsByType1 = new System.Windows.Forms.NumericUpDown();
            this.labelPollMDBBillPayoutString = new System.Windows.Forms.Label();
            this.label113 = new System.Windows.Forms.Label();
            this.label114 = new System.Windows.Forms.Label();
            this.label115 = new System.Windows.Forms.Label();
            this.label116 = new System.Windows.Forms.Label();
            this.buttonDispenseMDBBillsByType = new System.Windows.Forms.Button();
            this.labelRtnDispenseMDBBillsByType = new System.Windows.Forms.Label();
            this.buttonDispenseMDBBillsByValue = new System.Windows.Forms.Button();
            this.labelRtnPollMDBBillPayout = new System.Windows.Forms.Label();
            this.buttonPollMDBBillPayout = new System.Windows.Forms.Button();
            this.labelRtnDispenseMDBBillsByValue = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.labelRtnCancelMDBBillPayout = new System.Windows.Forms.Label();
            this.buttonCancelMDBBillPayout = new System.Windows.Forms.Button();
            this.label79 = new System.Windows.Forms.Label();
            this.label103 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.labelMDBBillCondition = new System.Windows.Forms.Label();
            this.labelMDBCoinCondition = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.checkBoxAutoFeed = new System.Windows.Forms.CheckBox();
            this.label48 = new System.Windows.Forms.Label();
            this.numericUpDownWatchDogReset = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownWatchDogReboot = new System.Windows.Forms.NumericUpDown();
            this.labelRtnSetWatchDog = new System.Windows.Forms.Label();
            this.numericUpDownWatchDogExpire = new System.Windows.Forms.NumericUpDown();
            this.buttonSetWatchDog = new System.Windows.Forms.Button();
            this.buttonFeedWatchDog = new System.Windows.Forms.Button();
            this.labelRtnFeedWatchDog = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelRtnSetRelayContact = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButtonRelayOff = new System.Windows.Forms.RadioButton();
            this.radioButtonRelayOn = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.timerAutoFeed = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPageSetCoinEnable.SuspendLayout();
            this.tabPageCoinTubeContent.SuspendLayout();
            this.tabPageCoinPayoutFinal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDispenseMDBCoinsByType1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDispenseMDBCoinsByType2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDispenseMDBCoinsByValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDispenseMDBBillsByValue)).BeginInit();
            this.tabPageGetRouteEnable.SuspendLayout();
            this.tabPageSetBillEnable.SuspendLayout();
            this.tabPageGetBillRouteTable.SuspendLayout();
            this.tabPageSetBillRouteEnable.SuspendLayout();
            this.tabPageRecyclerContent.SuspendLayout();
            this.tabPageRecyclerPayoutFinal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDispenseMDBBillsByType2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDispenseMDBBillsByType1)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWatchDogReset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWatchDogReboot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWatchDogExpire)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelRtnOpenCOM
            // 
            this.labelRtnOpenCOM.AutoSize = true;
            this.labelRtnOpenCOM.BackColor = System.Drawing.Color.White;
            this.labelRtnOpenCOM.Location = new System.Drawing.Point(179, 45);
            this.labelRtnOpenCOM.Name = "labelRtnOpenCOM";
            this.labelRtnOpenCOM.Size = new System.Drawing.Size(13, 13);
            this.labelRtnOpenCOM.TabIndex = 2;
            this.labelRtnOpenCOM.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "DLL version";
            // 
            // labelDLLVer
            // 
            this.labelDLLVer.AutoSize = true;
            this.labelDLLVer.Location = new System.Drawing.Point(79, 9);
            this.labelDLLVer.Name = "labelDLLVer";
            this.labelDLLVer.Size = new System.Drawing.Size(35, 13);
            this.labelDLLVer.TabIndex = 5;
            this.labelDLLVer.Text = "label4";
            // 
            // textBoxCOMPort
            // 
            this.textBoxCOMPort.Location = new System.Drawing.Point(144, 43);
            this.textBoxCOMPort.Name = "textBoxCOMPort";
            this.textBoxCOMPort.Size = new System.Drawing.Size(26, 20);
            this.textBoxCOMPort.TabIndex = 8;
            this.textBoxCOMPort.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 728);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Return Value  0= Ok; 1= No Response; 2= Cannot perform";
            // 
            // labelRtnCloseCOM
            // 
            this.labelRtnCloseCOM.AutoSize = true;
            this.labelRtnCloseCOM.BackColor = System.Drawing.Color.White;
            this.labelRtnCloseCOM.Location = new System.Drawing.Point(179, 75);
            this.labelRtnCloseCOM.Name = "labelRtnCloseCOM";
            this.labelRtnCloseCOM.Size = new System.Drawing.Size(13, 13);
            this.labelRtnCloseCOM.TabIndex = 10;
            this.labelRtnCloseCOM.Text = "0";
            // 
            // buttonOpenCOM
            // 
            this.buttonOpenCOM.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonOpenCOM.Location = new System.Drawing.Point(18, 41);
            this.buttonOpenCOM.Name = "buttonOpenCOM";
            this.buttonOpenCOM.Size = new System.Drawing.Size(118, 23);
            this.buttonOpenCOM.TabIndex = 11;
            this.buttonOpenCOM.Text = "Open COM";
            this.buttonOpenCOM.UseVisualStyleBackColor = false;
            this.buttonOpenCOM.Click += new System.EventHandler(this.buttonOpenCOM_Click);
            // 
            // buttonCloseCOM
            // 
            this.buttonCloseCOM.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonCloseCOM.Location = new System.Drawing.Point(18, 72);
            this.buttonCloseCOM.Name = "buttonCloseCOM";
            this.buttonCloseCOM.Size = new System.Drawing.Size(118, 23);
            this.buttonCloseCOM.TabIndex = 12;
            this.buttonCloseCOM.Text = "Close COM";
            this.buttonCloseCOM.UseVisualStyleBackColor = false;
            this.buttonCloseCOM.Click += new System.EventHandler(this.buttonCloseCOM_Click);
            // 
            // labelRtnGetSerialNumber
            // 
            this.labelRtnGetSerialNumber.AutoSize = true;
            this.labelRtnGetSerialNumber.BackColor = System.Drawing.Color.White;
            this.labelRtnGetSerialNumber.Location = new System.Drawing.Point(342, 44);
            this.labelRtnGetSerialNumber.Name = "labelRtnGetSerialNumber";
            this.labelRtnGetSerialNumber.Size = new System.Drawing.Size(13, 13);
            this.labelRtnGetSerialNumber.TabIndex = 14;
            this.labelRtnGetSerialNumber.Text = "0";
            // 
            // labelGetSerialNumberString
            // 
            this.labelGetSerialNumberString.AutoSize = true;
            this.labelGetSerialNumberString.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelGetSerialNumberString.Location = new System.Drawing.Point(364, 45);
            this.labelGetSerialNumberString.Name = "labelGetSerialNumberString";
            this.labelGetSerialNumberString.Size = new System.Drawing.Size(51, 13);
            this.labelGetSerialNumberString.TabIndex = 15;
            this.labelGetSerialNumberString.Text = "unknown";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gray;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 17;
            // 
            // labelRtnResetMDB
            // 
            this.labelRtnResetMDB.AutoSize = true;
            this.labelRtnResetMDB.BackColor = System.Drawing.Color.White;
            this.labelRtnResetMDB.Location = new System.Drawing.Point(578, 77);
            this.labelRtnResetMDB.Name = "labelRtnResetMDB";
            this.labelRtnResetMDB.Size = new System.Drawing.Size(13, 13);
            this.labelRtnResetMDB.TabIndex = 19;
            this.labelRtnResetMDB.Text = "0";
            // 
            // labelRtnPingIPC
            // 
            this.labelRtnPingIPC.AutoSize = true;
            this.labelRtnPingIPC.BackColor = System.Drawing.Color.White;
            this.labelRtnPingIPC.Location = new System.Drawing.Point(578, 45);
            this.labelRtnPingIPC.Name = "labelRtnPingIPC";
            this.labelRtnPingIPC.Size = new System.Drawing.Size(13, 13);
            this.labelRtnPingIPC.TabIndex = 21;
            this.labelRtnPingIPC.Text = "0";
            // 
            // labelGetKernelVersionString
            // 
            this.labelGetKernelVersionString.AutoSize = true;
            this.labelGetKernelVersionString.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelGetKernelVersionString.Location = new System.Drawing.Point(364, 78);
            this.labelGetKernelVersionString.Name = "labelGetKernelVersionString";
            this.labelGetKernelVersionString.Size = new System.Drawing.Size(51, 13);
            this.labelGetKernelVersionString.TabIndex = 24;
            this.labelGetKernelVersionString.Text = "unknown";
            // 
            // labelRtnGetKernelVersion
            // 
            this.labelRtnGetKernelVersion.AutoSize = true;
            this.labelRtnGetKernelVersion.BackColor = System.Drawing.Color.White;
            this.labelRtnGetKernelVersion.Location = new System.Drawing.Point(342, 77);
            this.labelRtnGetKernelVersion.Name = "labelRtnGetKernelVersion";
            this.labelRtnGetKernelVersion.Size = new System.Drawing.Size(13, 13);
            this.labelRtnGetKernelVersion.TabIndex = 23;
            this.labelRtnGetKernelVersion.Text = "0";
            // 
            // buttonGetSerialNumber
            // 
            this.buttonGetSerialNumber.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonGetSerialNumber.Location = new System.Drawing.Point(218, 40);
            this.buttonGetSerialNumber.Name = "buttonGetSerialNumber";
            this.buttonGetSerialNumber.Size = new System.Drawing.Size(118, 23);
            this.buttonGetSerialNumber.TabIndex = 34;
            this.buttonGetSerialNumber.Text = "Get Serial Number";
            this.buttonGetSerialNumber.UseVisualStyleBackColor = false;
            this.buttonGetSerialNumber.Click += new System.EventHandler(this.buttonGetSerialNumber_Click);
            // 
            // labelGetMDBBillStatusString
            // 
            this.labelGetMDBBillStatusString.AutoSize = true;
            this.labelGetMDBBillStatusString.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelGetMDBBillStatusString.Location = new System.Drawing.Point(700, 287);
            this.labelGetMDBBillStatusString.Name = "labelGetMDBBillStatusString";
            this.labelGetMDBBillStatusString.Size = new System.Drawing.Size(35, 13);
            this.labelGetMDBBillStatusString.TabIndex = 37;
            this.labelGetMDBBillStatusString.Text = "label1";
            // 
            // labelRtnGetMDBBillStatus
            // 
            this.labelRtnGetMDBBillStatus.AutoSize = true;
            this.labelRtnGetMDBBillStatus.BackColor = System.Drawing.Color.White;
            this.labelRtnGetMDBBillStatus.Location = new System.Drawing.Point(680, 287);
            this.labelRtnGetMDBBillStatus.Name = "labelRtnGetMDBBillStatus";
            this.labelRtnGetMDBBillStatus.Size = new System.Drawing.Size(13, 13);
            this.labelRtnGetMDBBillStatus.TabIndex = 36;
            this.labelRtnGetMDBBillStatus.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(16, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(982, 7);
            this.groupBox1.TabIndex = 143;
            this.groupBox1.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(207, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(224, 13);
            this.label15.TabIndex = 152;
            this.label15.Text = "Copyright 2018   Moneyflex Technologies LLC";
            // 
            // buttonPingIPC
            // 
            this.buttonPingIPC.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonPingIPC.Location = new System.Drawing.Point(451, 39);
            this.buttonPingIPC.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPingIPC.Name = "buttonPingIPC";
            this.buttonPingIPC.Size = new System.Drawing.Size(118, 23);
            this.buttonPingIPC.TabIndex = 153;
            this.buttonPingIPC.Text = "Ping IPC";
            this.buttonPingIPC.UseVisualStyleBackColor = false;
            this.buttonPingIPC.Click += new System.EventHandler(this.buttonPingIPC_Click);
            // 
            // buttonGetKernelVersion
            // 
            this.buttonGetKernelVersion.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonGetKernelVersion.Location = new System.Drawing.Point(218, 73);
            this.buttonGetKernelVersion.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGetKernelVersion.Name = "buttonGetKernelVersion";
            this.buttonGetKernelVersion.Size = new System.Drawing.Size(118, 21);
            this.buttonGetKernelVersion.TabIndex = 154;
            this.buttonGetKernelVersion.Text = "Get Kernel Version";
            this.buttonGetKernelVersion.UseVisualStyleBackColor = false;
            this.buttonGetKernelVersion.Click += new System.EventHandler(this.buttonGetKernelVersion_Click);
            // 
            // buttonResetMDB
            // 
            this.buttonResetMDB.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonResetMDB.Location = new System.Drawing.Point(451, 73);
            this.buttonResetMDB.Margin = new System.Windows.Forms.Padding(2);
            this.buttonResetMDB.Name = "buttonResetMDB";
            this.buttonResetMDB.Size = new System.Drawing.Size(118, 22);
            this.buttonResetMDB.TabIndex = 155;
            this.buttonResetMDB.Text = "Reset MDB";
            this.buttonResetMDB.UseVisualStyleBackColor = false;
            this.buttonResetMDB.Click += new System.EventHandler(this.buttonResetMDB_Click);
            // 
            // buttonGetMDBBillStatus
            // 
            this.buttonGetMDBBillStatus.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonGetMDBBillStatus.Location = new System.Drawing.Point(510, 281);
            this.buttonGetMDBBillStatus.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGetMDBBillStatus.Name = "buttonGetMDBBillStatus";
            this.buttonGetMDBBillStatus.Size = new System.Drawing.Size(118, 24);
            this.buttonGetMDBBillStatus.TabIndex = 156;
            this.buttonGetMDBBillStatus.Text = "Get Bill Status";
            this.buttonGetMDBBillStatus.UseVisualStyleBackColor = false;
            this.buttonGetMDBBillStatus.Click += new System.EventHandler(this.buttonGetMDBBillStatus_Click);
            // 
            // timerAutoPoll
            // 
            this.timerAutoPoll.Enabled = true;
            this.timerAutoPoll.Interval = 200;
            this.timerAutoPoll.Tick += new System.EventHandler(this.timerAutoPoll_Tick);
            // 
            // checkBoxAutoBill
            // 
            this.checkBoxAutoBill.AutoSize = true;
            this.checkBoxAutoBill.Checked = true;
            this.checkBoxAutoBill.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAutoBill.Location = new System.Drawing.Point(632, 286);
            this.checkBoxAutoBill.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxAutoBill.Name = "checkBoxAutoBill";
            this.checkBoxAutoBill.Size = new System.Drawing.Size(48, 17);
            this.checkBoxAutoBill.TabIndex = 157;
            this.checkBoxAutoBill.Text = "Auto";
            this.checkBoxAutoBill.UseVisualStyleBackColor = true;
            // 
            // checkBoxAutoCoin
            // 
            this.checkBoxAutoCoin.AutoSize = true;
            this.checkBoxAutoCoin.Checked = true;
            this.checkBoxAutoCoin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAutoCoin.Location = new System.Drawing.Point(139, 286);
            this.checkBoxAutoCoin.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxAutoCoin.Name = "checkBoxAutoCoin";
            this.checkBoxAutoCoin.Size = new System.Drawing.Size(48, 17);
            this.checkBoxAutoCoin.TabIndex = 158;
            this.checkBoxAutoCoin.Text = "Auto";
            this.checkBoxAutoCoin.UseVisualStyleBackColor = true;
            // 
            // buttonGetMDBCoinStatus
            // 
            this.buttonGetMDBCoinStatus.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonGetMDBCoinStatus.Location = new System.Drawing.Point(17, 281);
            this.buttonGetMDBCoinStatus.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGetMDBCoinStatus.Name = "buttonGetMDBCoinStatus";
            this.buttonGetMDBCoinStatus.Size = new System.Drawing.Size(118, 24);
            this.buttonGetMDBCoinStatus.TabIndex = 161;
            this.buttonGetMDBCoinStatus.Text = "Get Coin Status";
            this.buttonGetMDBCoinStatus.UseVisualStyleBackColor = false;
            this.buttonGetMDBCoinStatus.Click += new System.EventHandler(this.buttonGetMDBCoinStatus_Click);
            // 
            // labelGetMDBCoinStatusString
            // 
            this.labelGetMDBCoinStatusString.AutoSize = true;
            this.labelGetMDBCoinStatusString.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelGetMDBCoinStatusString.Location = new System.Drawing.Point(207, 287);
            this.labelGetMDBCoinStatusString.Name = "labelGetMDBCoinStatusString";
            this.labelGetMDBCoinStatusString.Size = new System.Drawing.Size(35, 13);
            this.labelGetMDBCoinStatusString.TabIndex = 160;
            this.labelGetMDBCoinStatusString.Text = "label1";
            // 
            // labelRtnGetMDBCoinStatus
            // 
            this.labelRtnGetMDBCoinStatus.AutoSize = true;
            this.labelRtnGetMDBCoinStatus.BackColor = System.Drawing.Color.White;
            this.labelRtnGetMDBCoinStatus.Location = new System.Drawing.Point(188, 287);
            this.labelRtnGetMDBCoinStatus.Name = "labelRtnGetMDBCoinStatus";
            this.labelRtnGetMDBCoinStatus.Size = new System.Drawing.Size(13, 13);
            this.labelRtnGetMDBCoinStatus.TabIndex = 159;
            this.labelRtnGetMDBCoinStatus.Text = "0";
            // 
            // labelRtnDispenseMDBCoinsByValue
            // 
            this.labelRtnDispenseMDBCoinsByValue.AutoSize = true;
            this.labelRtnDispenseMDBCoinsByValue.BackColor = System.Drawing.Color.White;
            this.labelRtnDispenseMDBCoinsByValue.Location = new System.Drawing.Point(423, 638);
            this.labelRtnDispenseMDBCoinsByValue.Name = "labelRtnDispenseMDBCoinsByValue";
            this.labelRtnDispenseMDBCoinsByValue.Size = new System.Drawing.Size(13, 13);
            this.labelRtnDispenseMDBCoinsByValue.TabIndex = 164;
            this.labelRtnDispenseMDBCoinsByValue.Text = "0";
            // 
            // labelRtnGetMDBCoinPayoutFinal
            // 
            this.labelRtnGetMDBCoinPayoutFinal.AutoSize = true;
            this.labelRtnGetMDBCoinPayoutFinal.BackColor = System.Drawing.Color.White;
            this.labelRtnGetMDBCoinPayoutFinal.Location = new System.Drawing.Point(262, 123);
            this.labelRtnGetMDBCoinPayoutFinal.Name = "labelRtnGetMDBCoinPayoutFinal";
            this.labelRtnGetMDBCoinPayoutFinal.Size = new System.Drawing.Size(13, 13);
            this.labelRtnGetMDBCoinPayoutFinal.TabIndex = 165;
            this.labelRtnGetMDBCoinPayoutFinal.Text = "0";
            // 
            // labelRtnSetMDBCoinChannels
            // 
            this.labelRtnSetMDBCoinChannels.AutoSize = true;
            this.labelRtnSetMDBCoinChannels.BackColor = System.Drawing.Color.White;
            this.labelRtnSetMDBCoinChannels.Location = new System.Drawing.Point(262, 124);
            this.labelRtnSetMDBCoinChannels.Name = "labelRtnSetMDBCoinChannels";
            this.labelRtnSetMDBCoinChannels.Size = new System.Drawing.Size(13, 13);
            this.labelRtnSetMDBCoinChannels.TabIndex = 170;
            this.labelRtnSetMDBCoinChannels.Text = "0";
            // 
            // buttonSetMDBCoinChannels
            // 
            this.buttonSetMDBCoinChannels.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonSetMDBCoinChannels.Location = new System.Drawing.Point(42, 118);
            this.buttonSetMDBCoinChannels.Name = "buttonSetMDBCoinChannels";
            this.buttonSetMDBCoinChannels.Size = new System.Drawing.Size(118, 24);
            this.buttonSetMDBCoinChannels.TabIndex = 168;
            this.buttonSetMDBCoinChannels.Text = "Set Coin Enable";
            this.buttonSetMDBCoinChannels.UseVisualStyleBackColor = false;
            this.buttonSetMDBCoinChannels.Click += new System.EventHandler(this.buttonSetMDBCoinChannels_Click);
            // 
            // buttonGetMDBCoinPayoutFinal
            // 
            this.buttonGetMDBCoinPayoutFinal.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonGetMDBCoinPayoutFinal.Location = new System.Drawing.Point(35, 117);
            this.buttonGetMDBCoinPayoutFinal.Name = "buttonGetMDBCoinPayoutFinal";
            this.buttonGetMDBCoinPayoutFinal.Size = new System.Drawing.Size(120, 24);
            this.buttonGetMDBCoinPayoutFinal.TabIndex = 172;
            this.buttonGetMDBCoinPayoutFinal.Text = "Final Coin Payout";
            this.buttonGetMDBCoinPayoutFinal.UseVisualStyleBackColor = false;
            this.buttonGetMDBCoinPayoutFinal.Click += new System.EventHandler(this.buttonGetMDBCoinPayoutFinal_Click);
            // 
            // buttonPollMDBCoinPayout
            // 
            this.buttonPollMDBCoinPayout.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonPollMDBCoinPayout.Location = new System.Drawing.Point(17, 668);
            this.buttonPollMDBCoinPayout.Name = "buttonPollMDBCoinPayout";
            this.buttonPollMDBCoinPayout.Size = new System.Drawing.Size(118, 24);
            this.buttonPollMDBCoinPayout.TabIndex = 175;
            this.buttonPollMDBCoinPayout.Text = "Poll Coin Payout";
            this.buttonPollMDBCoinPayout.UseVisualStyleBackColor = false;
            this.buttonPollMDBCoinPayout.Click += new System.EventHandler(this.buttonPollMDBCoinPayout_Click);
            // 
            // labelRtnPollMDBCoinPayout
            // 
            this.labelRtnPollMDBCoinPayout.AutoSize = true;
            this.labelRtnPollMDBCoinPayout.BackColor = System.Drawing.Color.White;
            this.labelRtnPollMDBCoinPayout.Location = new System.Drawing.Point(225, 674);
            this.labelRtnPollMDBCoinPayout.Name = "labelRtnPollMDBCoinPayout";
            this.labelRtnPollMDBCoinPayout.Size = new System.Drawing.Size(13, 13);
            this.labelRtnPollMDBCoinPayout.TabIndex = 173;
            this.labelRtnPollMDBCoinPayout.Text = "0";
            // 
            // labelCoinCh0
            // 
            this.labelCoinCh0.AutoSize = true;
            this.labelCoinCh0.BackColor = System.Drawing.Color.Gray;
            this.labelCoinCh0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelCoinCh0.Location = new System.Drawing.Point(155, 193);
            this.labelCoinCh0.Name = "labelCoinCh0";
            this.labelCoinCh0.Size = new System.Drawing.Size(16, 17);
            this.labelCoinCh0.TabIndex = 176;
            this.labelCoinCh0.Text = "0";
            this.labelCoinCh0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCoinCh1
            // 
            this.labelCoinCh1.AutoSize = true;
            this.labelCoinCh1.BackColor = System.Drawing.Color.Gray;
            this.labelCoinCh1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelCoinCh1.Location = new System.Drawing.Point(228, 193);
            this.labelCoinCh1.Name = "labelCoinCh1";
            this.labelCoinCh1.Size = new System.Drawing.Size(16, 17);
            this.labelCoinCh1.TabIndex = 177;
            this.labelCoinCh1.Text = "0";
            this.labelCoinCh1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCoinCh2
            // 
            this.labelCoinCh2.AutoSize = true;
            this.labelCoinCh2.BackColor = System.Drawing.Color.Gray;
            this.labelCoinCh2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelCoinCh2.Location = new System.Drawing.Point(300, 193);
            this.labelCoinCh2.Name = "labelCoinCh2";
            this.labelCoinCh2.Size = new System.Drawing.Size(16, 17);
            this.labelCoinCh2.TabIndex = 178;
            this.labelCoinCh2.Text = "0";
            this.labelCoinCh2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCoinCh3
            // 
            this.labelCoinCh3.AutoSize = true;
            this.labelCoinCh3.BackColor = System.Drawing.Color.Gray;
            this.labelCoinCh3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelCoinCh3.Location = new System.Drawing.Point(376, 193);
            this.labelCoinCh3.Name = "labelCoinCh3";
            this.labelCoinCh3.Size = new System.Drawing.Size(16, 17);
            this.labelCoinCh3.TabIndex = 179;
            this.labelCoinCh3.Text = "0";
            this.labelCoinCh3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCoinCh7
            // 
            this.labelCoinCh7.AutoSize = true;
            this.labelCoinCh7.BackColor = System.Drawing.Color.Gray;
            this.labelCoinCh7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelCoinCh7.Location = new System.Drawing.Point(376, 215);
            this.labelCoinCh7.Name = "labelCoinCh7";
            this.labelCoinCh7.Size = new System.Drawing.Size(16, 17);
            this.labelCoinCh7.TabIndex = 183;
            this.labelCoinCh7.Text = "0";
            this.labelCoinCh7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCoinCh6
            // 
            this.labelCoinCh6.AutoSize = true;
            this.labelCoinCh6.BackColor = System.Drawing.Color.Gray;
            this.labelCoinCh6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelCoinCh6.Location = new System.Drawing.Point(300, 215);
            this.labelCoinCh6.Name = "labelCoinCh6";
            this.labelCoinCh6.Size = new System.Drawing.Size(16, 17);
            this.labelCoinCh6.TabIndex = 182;
            this.labelCoinCh6.Text = "0";
            this.labelCoinCh6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCoinCh5
            // 
            this.labelCoinCh5.AutoSize = true;
            this.labelCoinCh5.BackColor = System.Drawing.Color.Gray;
            this.labelCoinCh5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelCoinCh5.Location = new System.Drawing.Point(228, 215);
            this.labelCoinCh5.Name = "labelCoinCh5";
            this.labelCoinCh5.Size = new System.Drawing.Size(16, 17);
            this.labelCoinCh5.TabIndex = 181;
            this.labelCoinCh5.Text = "0";
            this.labelCoinCh5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCoinCh4
            // 
            this.labelCoinCh4.AutoSize = true;
            this.labelCoinCh4.BackColor = System.Drawing.Color.Gray;
            this.labelCoinCh4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelCoinCh4.Location = new System.Drawing.Point(155, 215);
            this.labelCoinCh4.Name = "labelCoinCh4";
            this.labelCoinCh4.Size = new System.Drawing.Size(16, 17);
            this.labelCoinCh4.TabIndex = 180;
            this.labelCoinCh4.Text = "0";
            this.labelCoinCh4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCoinCh11
            // 
            this.labelCoinCh11.AutoSize = true;
            this.labelCoinCh11.BackColor = System.Drawing.Color.Gray;
            this.labelCoinCh11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelCoinCh11.Location = new System.Drawing.Point(376, 237);
            this.labelCoinCh11.Name = "labelCoinCh11";
            this.labelCoinCh11.Size = new System.Drawing.Size(16, 17);
            this.labelCoinCh11.TabIndex = 187;
            this.labelCoinCh11.Text = "0";
            this.labelCoinCh11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCoinCh10
            // 
            this.labelCoinCh10.AutoSize = true;
            this.labelCoinCh10.BackColor = System.Drawing.Color.Gray;
            this.labelCoinCh10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelCoinCh10.Location = new System.Drawing.Point(300, 237);
            this.labelCoinCh10.Name = "labelCoinCh10";
            this.labelCoinCh10.Size = new System.Drawing.Size(16, 17);
            this.labelCoinCh10.TabIndex = 186;
            this.labelCoinCh10.Text = "0";
            this.labelCoinCh10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCoinCh9
            // 
            this.labelCoinCh9.AutoSize = true;
            this.labelCoinCh9.BackColor = System.Drawing.Color.Gray;
            this.labelCoinCh9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelCoinCh9.Location = new System.Drawing.Point(228, 237);
            this.labelCoinCh9.Name = "labelCoinCh9";
            this.labelCoinCh9.Size = new System.Drawing.Size(16, 17);
            this.labelCoinCh9.TabIndex = 185;
            this.labelCoinCh9.Text = "0";
            this.labelCoinCh9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCoinCh8
            // 
            this.labelCoinCh8.AutoSize = true;
            this.labelCoinCh8.BackColor = System.Drawing.Color.Gray;
            this.labelCoinCh8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelCoinCh8.Location = new System.Drawing.Point(155, 237);
            this.labelCoinCh8.Name = "labelCoinCh8";
            this.labelCoinCh8.Size = new System.Drawing.Size(16, 17);
            this.labelCoinCh8.TabIndex = 184;
            this.labelCoinCh8.Text = "0";
            this.labelCoinCh8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCoinCh15
            // 
            this.labelCoinCh15.AutoSize = true;
            this.labelCoinCh15.BackColor = System.Drawing.Color.Gray;
            this.labelCoinCh15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelCoinCh15.Location = new System.Drawing.Point(376, 258);
            this.labelCoinCh15.Name = "labelCoinCh15";
            this.labelCoinCh15.Size = new System.Drawing.Size(16, 17);
            this.labelCoinCh15.TabIndex = 191;
            this.labelCoinCh15.Text = "0";
            this.labelCoinCh15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCoinCh14
            // 
            this.labelCoinCh14.AutoSize = true;
            this.labelCoinCh14.BackColor = System.Drawing.Color.Gray;
            this.labelCoinCh14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelCoinCh14.Location = new System.Drawing.Point(300, 258);
            this.labelCoinCh14.Name = "labelCoinCh14";
            this.labelCoinCh14.Size = new System.Drawing.Size(16, 17);
            this.labelCoinCh14.TabIndex = 190;
            this.labelCoinCh14.Text = "0";
            this.labelCoinCh14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCoinCh13
            // 
            this.labelCoinCh13.AutoSize = true;
            this.labelCoinCh13.BackColor = System.Drawing.Color.Gray;
            this.labelCoinCh13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelCoinCh13.Location = new System.Drawing.Point(228, 258);
            this.labelCoinCh13.Name = "labelCoinCh13";
            this.labelCoinCh13.Size = new System.Drawing.Size(16, 17);
            this.labelCoinCh13.TabIndex = 189;
            this.labelCoinCh13.Text = "0";
            this.labelCoinCh13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCoinCh12
            // 
            this.labelCoinCh12.AutoSize = true;
            this.labelCoinCh12.BackColor = System.Drawing.Color.Gray;
            this.labelCoinCh12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelCoinCh12.Location = new System.Drawing.Point(155, 258);
            this.labelCoinCh12.Name = "labelCoinCh12";
            this.labelCoinCh12.Size = new System.Drawing.Size(16, 17);
            this.labelCoinCh12.TabIndex = 188;
            this.labelCoinCh12.Text = "0";
            this.labelCoinCh12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCoinLevel
            // 
            this.labelCoinLevel.AutoSize = true;
            this.labelCoinLevel.BackColor = System.Drawing.Color.Gray;
            this.labelCoinLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelCoinLevel.Location = new System.Drawing.Point(255, 147);
            this.labelCoinLevel.Name = "labelCoinLevel";
            this.labelCoinLevel.Size = new System.Drawing.Size(16, 17);
            this.labelCoinLevel.TabIndex = 192;
            this.labelCoinLevel.Text = "0";
            this.labelCoinLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCoinScale
            // 
            this.labelCoinScale.AutoSize = true;
            this.labelCoinScale.BackColor = System.Drawing.Color.Gray;
            this.labelCoinScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelCoinScale.Location = new System.Drawing.Point(255, 168);
            this.labelCoinScale.Name = "labelCoinScale";
            this.labelCoinScale.Size = new System.Drawing.Size(16, 17);
            this.labelCoinScale.TabIndex = 193;
            this.labelCoinScale.Text = "0";
            this.labelCoinScale.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCoinDecimal
            // 
            this.labelCoinDecimal.AutoSize = true;
            this.labelCoinDecimal.BackColor = System.Drawing.Color.Gray;
            this.labelCoinDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelCoinDecimal.Location = new System.Drawing.Point(410, 168);
            this.labelCoinDecimal.Name = "labelCoinDecimal";
            this.labelCoinDecimal.Size = new System.Drawing.Size(16, 17);
            this.labelCoinDecimal.TabIndex = 194;
            this.labelCoinDecimal.Text = "0";
            this.labelCoinDecimal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(46, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 17);
            this.label8.TabIndex = 195;
            this.label8.Text = "Ch0 to Ch3 ->";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(46, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 17);
            this.label9.TabIndex = 196;
            this.label9.Text = "Ch4 to Ch7 ->";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(38, 237);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 17);
            this.label10.TabIndex = 197;
            this.label10.Text = "Ch8 to Ch11 ->";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(30, 258);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 17);
            this.label11.TabIndex = 198;
            this.label11.Text = "Ch12 to Ch15 ->";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.Control;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(149, 147);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 17);
            this.label12.TabIndex = 199;
            this.label12.Text = "Feature Level";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.Control;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(149, 168);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 17);
            this.label13.TabIndex = 200;
            this.label13.Text = "Scaling Factor";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.Control;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(307, 168);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 17);
            this.label14.TabIndex = 201;
            this.label14.Text = "Decimal Place";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.Control;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(307, 147);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(94, 17);
            this.label16.TabIndex = 202;
            this.label16.Text = "Country Code";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCoinISO
            // 
            this.labelCoinISO.AutoSize = true;
            this.labelCoinISO.BackColor = System.Drawing.Color.Gray;
            this.labelCoinISO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelCoinISO.Location = new System.Drawing.Point(410, 147);
            this.labelCoinISO.Name = "labelCoinISO";
            this.labelCoinISO.Size = new System.Drawing.Size(16, 17);
            this.labelCoinISO.TabIndex = 203;
            this.labelCoinISO.Text = "0";
            this.labelCoinISO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonGetMDBCoinSetup
            // 
            this.buttonGetMDBCoinSetup.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonGetMDBCoinSetup.Location = new System.Drawing.Point(17, 138);
            this.buttonGetMDBCoinSetup.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGetMDBCoinSetup.Name = "buttonGetMDBCoinSetup";
            this.buttonGetMDBCoinSetup.Size = new System.Drawing.Size(118, 24);
            this.buttonGetMDBCoinSetup.TabIndex = 206;
            this.buttonGetMDBCoinSetup.Text = "Get Device Setup";
            this.buttonGetMDBCoinSetup.UseVisualStyleBackColor = false;
            this.buttonGetMDBCoinSetup.Click += new System.EventHandler(this.buttonGetMDBCoinSetup_Click);
            // 
            // labelMiscMDBCmdRepliedString
            // 
            this.labelMiscMDBCmdRepliedString.AutoSize = true;
            this.labelMiscMDBCmdRepliedString.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelMiscMDBCmdRepliedString.Location = new System.Drawing.Point(88, 704);
            this.labelMiscMDBCmdRepliedString.Name = "labelMiscMDBCmdRepliedString";
            this.labelMiscMDBCmdRepliedString.Size = new System.Drawing.Size(31, 13);
            this.labelMiscMDBCmdRepliedString.TabIndex = 205;
            this.labelMiscMDBCmdRepliedString.Text = "none";
            // 
            // labelRtnGetMDBCoinSetup
            // 
            this.labelRtnGetMDBCoinSetup.AutoSize = true;
            this.labelRtnGetMDBCoinSetup.BackColor = System.Drawing.Color.White;
            this.labelRtnGetMDBCoinSetup.Location = new System.Drawing.Point(100, 171);
            this.labelRtnGetMDBCoinSetup.Name = "labelRtnGetMDBCoinSetup";
            this.labelRtnGetMDBCoinSetup.Size = new System.Drawing.Size(13, 13);
            this.labelRtnGetMDBCoinSetup.TabIndex = 204;
            this.labelRtnGetMDBCoinSetup.Text = "0";
            // 
            // checkBoxCoinEnable0
            // 
            this.checkBoxCoinEnable0.AutoSize = true;
            this.checkBoxCoinEnable0.Checked = true;
            this.checkBoxCoinEnable0.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCoinEnable0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCoinEnable0.Location = new System.Drawing.Point(82, 12);
            this.checkBoxCoinEnable0.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxCoinEnable0.Name = "checkBoxCoinEnable0";
            this.checkBoxCoinEnable0.Size = new System.Drawing.Size(50, 20);
            this.checkBoxCoinEnable0.TabIndex = 207;
            this.checkBoxCoinEnable0.Text = "Ch0";
            this.checkBoxCoinEnable0.UseVisualStyleBackColor = true;
            // 
            // checkBoxCoinEnable1
            // 
            this.checkBoxCoinEnable1.AutoSize = true;
            this.checkBoxCoinEnable1.Checked = true;
            this.checkBoxCoinEnable1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCoinEnable1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCoinEnable1.Location = new System.Drawing.Point(154, 12);
            this.checkBoxCoinEnable1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxCoinEnable1.Name = "checkBoxCoinEnable1";
            this.checkBoxCoinEnable1.Size = new System.Drawing.Size(50, 20);
            this.checkBoxCoinEnable1.TabIndex = 208;
            this.checkBoxCoinEnable1.Text = "Ch1";
            this.checkBoxCoinEnable1.UseVisualStyleBackColor = true;
            // 
            // checkBoxCoinEnable2
            // 
            this.checkBoxCoinEnable2.AutoSize = true;
            this.checkBoxCoinEnable2.Checked = true;
            this.checkBoxCoinEnable2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCoinEnable2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCoinEnable2.Location = new System.Drawing.Point(226, 12);
            this.checkBoxCoinEnable2.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxCoinEnable2.Name = "checkBoxCoinEnable2";
            this.checkBoxCoinEnable2.Size = new System.Drawing.Size(50, 20);
            this.checkBoxCoinEnable2.TabIndex = 209;
            this.checkBoxCoinEnable2.Text = "Ch2";
            this.checkBoxCoinEnable2.UseVisualStyleBackColor = true;
            // 
            // checkBoxCoinEnable3
            // 
            this.checkBoxCoinEnable3.AutoSize = true;
            this.checkBoxCoinEnable3.Checked = true;
            this.checkBoxCoinEnable3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCoinEnable3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCoinEnable3.Location = new System.Drawing.Point(294, 12);
            this.checkBoxCoinEnable3.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxCoinEnable3.Name = "checkBoxCoinEnable3";
            this.checkBoxCoinEnable3.Size = new System.Drawing.Size(50, 20);
            this.checkBoxCoinEnable3.TabIndex = 210;
            this.checkBoxCoinEnable3.Text = "Ch3";
            this.checkBoxCoinEnable3.UseVisualStyleBackColor = true;
            // 
            // checkBoxCoinEnable4
            // 
            this.checkBoxCoinEnable4.AutoSize = true;
            this.checkBoxCoinEnable4.Checked = true;
            this.checkBoxCoinEnable4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCoinEnable4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCoinEnable4.Location = new System.Drawing.Point(82, 36);
            this.checkBoxCoinEnable4.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxCoinEnable4.Name = "checkBoxCoinEnable4";
            this.checkBoxCoinEnable4.Size = new System.Drawing.Size(50, 20);
            this.checkBoxCoinEnable4.TabIndex = 211;
            this.checkBoxCoinEnable4.Text = "Ch4";
            this.checkBoxCoinEnable4.UseVisualStyleBackColor = true;
            // 
            // checkBoxCoinEnable5
            // 
            this.checkBoxCoinEnable5.AutoSize = true;
            this.checkBoxCoinEnable5.Checked = true;
            this.checkBoxCoinEnable5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCoinEnable5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCoinEnable5.Location = new System.Drawing.Point(156, 36);
            this.checkBoxCoinEnable5.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxCoinEnable5.Name = "checkBoxCoinEnable5";
            this.checkBoxCoinEnable5.Size = new System.Drawing.Size(50, 20);
            this.checkBoxCoinEnable5.TabIndex = 212;
            this.checkBoxCoinEnable5.Text = "Ch5";
            this.checkBoxCoinEnable5.UseVisualStyleBackColor = true;
            // 
            // checkBoxCoinEnable6
            // 
            this.checkBoxCoinEnable6.AutoSize = true;
            this.checkBoxCoinEnable6.Checked = true;
            this.checkBoxCoinEnable6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCoinEnable6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCoinEnable6.Location = new System.Drawing.Point(226, 36);
            this.checkBoxCoinEnable6.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxCoinEnable6.Name = "checkBoxCoinEnable6";
            this.checkBoxCoinEnable6.Size = new System.Drawing.Size(50, 20);
            this.checkBoxCoinEnable6.TabIndex = 213;
            this.checkBoxCoinEnable6.Text = "Ch6";
            this.checkBoxCoinEnable6.UseVisualStyleBackColor = true;
            // 
            // checkBoxCoinEnable7
            // 
            this.checkBoxCoinEnable7.AutoSize = true;
            this.checkBoxCoinEnable7.Checked = true;
            this.checkBoxCoinEnable7.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCoinEnable7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCoinEnable7.Location = new System.Drawing.Point(294, 36);
            this.checkBoxCoinEnable7.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxCoinEnable7.Name = "checkBoxCoinEnable7";
            this.checkBoxCoinEnable7.Size = new System.Drawing.Size(50, 20);
            this.checkBoxCoinEnable7.TabIndex = 214;
            this.checkBoxCoinEnable7.Text = "Ch7";
            this.checkBoxCoinEnable7.UseVisualStyleBackColor = true;
            // 
            // checkBoxCoinEnable11
            // 
            this.checkBoxCoinEnable11.AutoSize = true;
            this.checkBoxCoinEnable11.Checked = true;
            this.checkBoxCoinEnable11.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCoinEnable11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCoinEnable11.Location = new System.Drawing.Point(294, 60);
            this.checkBoxCoinEnable11.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxCoinEnable11.Name = "checkBoxCoinEnable11";
            this.checkBoxCoinEnable11.Size = new System.Drawing.Size(57, 20);
            this.checkBoxCoinEnable11.TabIndex = 218;
            this.checkBoxCoinEnable11.Text = "Ch11";
            this.checkBoxCoinEnable11.UseVisualStyleBackColor = true;
            // 
            // checkBoxCoinEnable10
            // 
            this.checkBoxCoinEnable10.AutoSize = true;
            this.checkBoxCoinEnable10.Checked = true;
            this.checkBoxCoinEnable10.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCoinEnable10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCoinEnable10.Location = new System.Drawing.Point(226, 60);
            this.checkBoxCoinEnable10.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxCoinEnable10.Name = "checkBoxCoinEnable10";
            this.checkBoxCoinEnable10.Size = new System.Drawing.Size(57, 20);
            this.checkBoxCoinEnable10.TabIndex = 217;
            this.checkBoxCoinEnable10.Text = "Ch10";
            this.checkBoxCoinEnable10.UseVisualStyleBackColor = true;
            // 
            // checkBoxCoinEnable9
            // 
            this.checkBoxCoinEnable9.AutoSize = true;
            this.checkBoxCoinEnable9.Checked = true;
            this.checkBoxCoinEnable9.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCoinEnable9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCoinEnable9.Location = new System.Drawing.Point(156, 60);
            this.checkBoxCoinEnable9.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxCoinEnable9.Name = "checkBoxCoinEnable9";
            this.checkBoxCoinEnable9.Size = new System.Drawing.Size(50, 20);
            this.checkBoxCoinEnable9.TabIndex = 216;
            this.checkBoxCoinEnable9.Text = "Ch9";
            this.checkBoxCoinEnable9.UseVisualStyleBackColor = true;
            // 
            // checkBoxCoinEnable8
            // 
            this.checkBoxCoinEnable8.AutoSize = true;
            this.checkBoxCoinEnable8.Checked = true;
            this.checkBoxCoinEnable8.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCoinEnable8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCoinEnable8.Location = new System.Drawing.Point(82, 60);
            this.checkBoxCoinEnable8.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxCoinEnable8.Name = "checkBoxCoinEnable8";
            this.checkBoxCoinEnable8.Size = new System.Drawing.Size(50, 20);
            this.checkBoxCoinEnable8.TabIndex = 215;
            this.checkBoxCoinEnable8.Text = "Ch8";
            this.checkBoxCoinEnable8.UseVisualStyleBackColor = true;
            // 
            // checkBoxCoinEnable15
            // 
            this.checkBoxCoinEnable15.AutoSize = true;
            this.checkBoxCoinEnable15.Checked = true;
            this.checkBoxCoinEnable15.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCoinEnable15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCoinEnable15.Location = new System.Drawing.Point(294, 84);
            this.checkBoxCoinEnable15.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxCoinEnable15.Name = "checkBoxCoinEnable15";
            this.checkBoxCoinEnable15.Size = new System.Drawing.Size(57, 20);
            this.checkBoxCoinEnable15.TabIndex = 222;
            this.checkBoxCoinEnable15.Text = "Ch15";
            this.checkBoxCoinEnable15.UseVisualStyleBackColor = true;
            // 
            // checkBoxCoinEnable14
            // 
            this.checkBoxCoinEnable14.AutoSize = true;
            this.checkBoxCoinEnable14.Checked = true;
            this.checkBoxCoinEnable14.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCoinEnable14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCoinEnable14.Location = new System.Drawing.Point(226, 84);
            this.checkBoxCoinEnable14.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxCoinEnable14.Name = "checkBoxCoinEnable14";
            this.checkBoxCoinEnable14.Size = new System.Drawing.Size(57, 20);
            this.checkBoxCoinEnable14.TabIndex = 221;
            this.checkBoxCoinEnable14.Text = "Ch14";
            this.checkBoxCoinEnable14.UseVisualStyleBackColor = true;
            // 
            // checkBoxCoinEnable13
            // 
            this.checkBoxCoinEnable13.AutoSize = true;
            this.checkBoxCoinEnable13.Checked = true;
            this.checkBoxCoinEnable13.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCoinEnable13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCoinEnable13.Location = new System.Drawing.Point(156, 84);
            this.checkBoxCoinEnable13.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxCoinEnable13.Name = "checkBoxCoinEnable13";
            this.checkBoxCoinEnable13.Size = new System.Drawing.Size(57, 20);
            this.checkBoxCoinEnable13.TabIndex = 220;
            this.checkBoxCoinEnable13.Text = "Ch13";
            this.checkBoxCoinEnable13.UseVisualStyleBackColor = true;
            // 
            // checkBoxCoinEnable12
            // 
            this.checkBoxCoinEnable12.AutoSize = true;
            this.checkBoxCoinEnable12.Checked = true;
            this.checkBoxCoinEnable12.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCoinEnable12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCoinEnable12.Location = new System.Drawing.Point(82, 84);
            this.checkBoxCoinEnable12.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxCoinEnable12.Name = "checkBoxCoinEnable12";
            this.checkBoxCoinEnable12.Size = new System.Drawing.Size(57, 20);
            this.checkBoxCoinEnable12.TabIndex = 219;
            this.checkBoxCoinEnable12.Text = "Ch12";
            this.checkBoxCoinEnable12.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageSetCoinEnable);
            this.tabControl1.Controls.Add(this.tabPageCoinTubeContent);
            this.tabControl1.Controls.Add(this.tabPageCoinPayoutFinal);
            this.tabControl1.Location = new System.Drawing.Point(17, 402);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(440, 179);
            this.tabControl1.TabIndex = 223;
            // 
            // tabPageSetCoinEnable
            // 
            this.tabPageSetCoinEnable.BackColor = System.Drawing.Color.Tan;
            this.tabPageSetCoinEnable.Controls.Add(this.label24);
            this.tabPageSetCoinEnable.Controls.Add(this.buttonSetMDBCoinChannels);
            this.tabPageSetCoinEnable.Controls.Add(this.checkBoxCoinEnable15);
            this.tabPageSetCoinEnable.Controls.Add(this.checkBoxCoinEnable14);
            this.tabPageSetCoinEnable.Controls.Add(this.labelRtnSetMDBCoinChannels);
            this.tabPageSetCoinEnable.Controls.Add(this.checkBoxCoinEnable13);
            this.tabPageSetCoinEnable.Controls.Add(this.checkBoxCoinEnable12);
            this.tabPageSetCoinEnable.Controls.Add(this.checkBoxCoinEnable0);
            this.tabPageSetCoinEnable.Controls.Add(this.checkBoxCoinEnable11);
            this.tabPageSetCoinEnable.Controls.Add(this.checkBoxCoinEnable1);
            this.tabPageSetCoinEnable.Controls.Add(this.checkBoxCoinEnable10);
            this.tabPageSetCoinEnable.Controls.Add(this.checkBoxCoinEnable2);
            this.tabPageSetCoinEnable.Controls.Add(this.checkBoxCoinEnable9);
            this.tabPageSetCoinEnable.Controls.Add(this.checkBoxCoinEnable3);
            this.tabPageSetCoinEnable.Controls.Add(this.checkBoxCoinEnable8);
            this.tabPageSetCoinEnable.Controls.Add(this.checkBoxCoinEnable4);
            this.tabPageSetCoinEnable.Controls.Add(this.checkBoxCoinEnable7);
            this.tabPageSetCoinEnable.Controls.Add(this.checkBoxCoinEnable5);
            this.tabPageSetCoinEnable.Controls.Add(this.checkBoxCoinEnable6);
            this.tabPageSetCoinEnable.Location = new System.Drawing.Point(4, 22);
            this.tabPageSetCoinEnable.Name = "tabPageSetCoinEnable";
            this.tabPageSetCoinEnable.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSetCoinEnable.Size = new System.Drawing.Size(432, 153);
            this.tabPageSetCoinEnable.TabIndex = 0;
            this.tabPageSetCoinEnable.Text = "Channel Enable";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(178, 124);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(69, 13);
            this.label24.TabIndex = 241;
            this.label24.Text = "Return Value";
            // 
            // tabPageCoinTubeContent
            // 
            this.tabPageCoinTubeContent.BackColor = System.Drawing.Color.Tan;
            this.tabPageCoinTubeContent.Controls.Add(this.label25);
            this.tabPageCoinTubeContent.Controls.Add(this.labelRtnGetMDBCoinTubeContent);
            this.tabPageCoinTubeContent.Controls.Add(this.buttonGetMDBCoinTubeContent);
            this.tabPageCoinTubeContent.Controls.Add(this.label18);
            this.tabPageCoinTubeContent.Controls.Add(this.label19);
            this.tabPageCoinTubeContent.Controls.Add(this.label20);
            this.tabPageCoinTubeContent.Controls.Add(this.label21);
            this.tabPageCoinTubeContent.Controls.Add(this.labelTube15);
            this.tabPageCoinTubeContent.Controls.Add(this.labelTube14);
            this.tabPageCoinTubeContent.Controls.Add(this.labelTube13);
            this.tabPageCoinTubeContent.Controls.Add(this.labelTube12);
            this.tabPageCoinTubeContent.Controls.Add(this.labelTube11);
            this.tabPageCoinTubeContent.Controls.Add(this.labelTube10);
            this.tabPageCoinTubeContent.Controls.Add(this.labelTube9);
            this.tabPageCoinTubeContent.Controls.Add(this.labelTube8);
            this.tabPageCoinTubeContent.Controls.Add(this.labelTube7);
            this.tabPageCoinTubeContent.Controls.Add(this.labelTube6);
            this.tabPageCoinTubeContent.Controls.Add(this.labelTube5);
            this.tabPageCoinTubeContent.Controls.Add(this.labelTube4);
            this.tabPageCoinTubeContent.Controls.Add(this.labelTube3);
            this.tabPageCoinTubeContent.Controls.Add(this.labelTube2);
            this.tabPageCoinTubeContent.Controls.Add(this.labelTube1);
            this.tabPageCoinTubeContent.Controls.Add(this.labelTube0);
            this.tabPageCoinTubeContent.Location = new System.Drawing.Point(4, 22);
            this.tabPageCoinTubeContent.Name = "tabPageCoinTubeContent";
            this.tabPageCoinTubeContent.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCoinTubeContent.Size = new System.Drawing.Size(432, 153);
            this.tabPageCoinTubeContent.TabIndex = 1;
            this.tabPageCoinTubeContent.Text = "Tube Content";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(176, 124);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(69, 13);
            this.label25.TabIndex = 241;
            this.label25.Text = "Return Value";
            // 
            // labelRtnGetMDBCoinTubeContent
            // 
            this.labelRtnGetMDBCoinTubeContent.AutoSize = true;
            this.labelRtnGetMDBCoinTubeContent.BackColor = System.Drawing.Color.White;
            this.labelRtnGetMDBCoinTubeContent.Location = new System.Drawing.Point(260, 124);
            this.labelRtnGetMDBCoinTubeContent.Name = "labelRtnGetMDBCoinTubeContent";
            this.labelRtnGetMDBCoinTubeContent.Size = new System.Drawing.Size(13, 13);
            this.labelRtnGetMDBCoinTubeContent.TabIndex = 224;
            this.labelRtnGetMDBCoinTubeContent.Text = "0";
            // 
            // buttonGetMDBCoinTubeContent
            // 
            this.buttonGetMDBCoinTubeContent.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonGetMDBCoinTubeContent.Location = new System.Drawing.Point(40, 118);
            this.buttonGetMDBCoinTubeContent.Name = "buttonGetMDBCoinTubeContent";
            this.buttonGetMDBCoinTubeContent.Size = new System.Drawing.Size(118, 24);
            this.buttonGetMDBCoinTubeContent.TabIndex = 219;
            this.buttonGetMDBCoinTubeContent.Text = "Get Tube Content";
            this.buttonGetMDBCoinTubeContent.UseVisualStyleBackColor = false;
            this.buttonGetMDBCoinTubeContent.Click += new System.EventHandler(this.buttonGetMDBCoinTubeContent_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Tan;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.Location = new System.Drawing.Point(10, 90);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(111, 17);
            this.label18.TabIndex = 218;
            this.label18.Text = "Ch12 to Ch15 ->";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Tan;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.Location = new System.Drawing.Point(18, 64);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(103, 17);
            this.label19.TabIndex = 217;
            this.label19.Text = "Ch8 to Ch11 ->";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Tan;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.Location = new System.Drawing.Point(26, 38);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(95, 17);
            this.label20.TabIndex = 216;
            this.label20.Text = "Ch4 to Ch7 ->";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Tan;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label21.Location = new System.Drawing.Point(26, 12);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(95, 17);
            this.label21.TabIndex = 215;
            this.label21.Text = "Ch0 to Ch3 ->";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTube15
            // 
            this.labelTube15.AutoSize = true;
            this.labelTube15.BackColor = System.Drawing.Color.Gray;
            this.labelTube15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTube15.Location = new System.Drawing.Point(356, 90);
            this.labelTube15.Name = "labelTube15";
            this.labelTube15.Size = new System.Drawing.Size(16, 17);
            this.labelTube15.TabIndex = 214;
            this.labelTube15.Text = "0";
            this.labelTube15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTube14
            // 
            this.labelTube14.AutoSize = true;
            this.labelTube14.BackColor = System.Drawing.Color.Gray;
            this.labelTube14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTube14.Location = new System.Drawing.Point(280, 90);
            this.labelTube14.Name = "labelTube14";
            this.labelTube14.Size = new System.Drawing.Size(16, 17);
            this.labelTube14.TabIndex = 213;
            this.labelTube14.Text = "0";
            this.labelTube14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTube13
            // 
            this.labelTube13.AutoSize = true;
            this.labelTube13.BackColor = System.Drawing.Color.Gray;
            this.labelTube13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTube13.Location = new System.Drawing.Point(208, 90);
            this.labelTube13.Name = "labelTube13";
            this.labelTube13.Size = new System.Drawing.Size(16, 17);
            this.labelTube13.TabIndex = 212;
            this.labelTube13.Text = "0";
            this.labelTube13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTube12
            // 
            this.labelTube12.AutoSize = true;
            this.labelTube12.BackColor = System.Drawing.Color.Gray;
            this.labelTube12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTube12.Location = new System.Drawing.Point(135, 90);
            this.labelTube12.Name = "labelTube12";
            this.labelTube12.Size = new System.Drawing.Size(16, 17);
            this.labelTube12.TabIndex = 211;
            this.labelTube12.Text = "0";
            this.labelTube12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTube11
            // 
            this.labelTube11.AutoSize = true;
            this.labelTube11.BackColor = System.Drawing.Color.Gray;
            this.labelTube11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTube11.Location = new System.Drawing.Point(356, 64);
            this.labelTube11.Name = "labelTube11";
            this.labelTube11.Size = new System.Drawing.Size(16, 17);
            this.labelTube11.TabIndex = 210;
            this.labelTube11.Text = "0";
            this.labelTube11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTube10
            // 
            this.labelTube10.AutoSize = true;
            this.labelTube10.BackColor = System.Drawing.Color.Gray;
            this.labelTube10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTube10.Location = new System.Drawing.Point(280, 64);
            this.labelTube10.Name = "labelTube10";
            this.labelTube10.Size = new System.Drawing.Size(16, 17);
            this.labelTube10.TabIndex = 209;
            this.labelTube10.Text = "0";
            this.labelTube10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTube9
            // 
            this.labelTube9.AutoSize = true;
            this.labelTube9.BackColor = System.Drawing.Color.Gray;
            this.labelTube9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTube9.Location = new System.Drawing.Point(208, 64);
            this.labelTube9.Name = "labelTube9";
            this.labelTube9.Size = new System.Drawing.Size(16, 17);
            this.labelTube9.TabIndex = 208;
            this.labelTube9.Text = "0";
            this.labelTube9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTube8
            // 
            this.labelTube8.AutoSize = true;
            this.labelTube8.BackColor = System.Drawing.Color.Gray;
            this.labelTube8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTube8.Location = new System.Drawing.Point(135, 64);
            this.labelTube8.Name = "labelTube8";
            this.labelTube8.Size = new System.Drawing.Size(16, 17);
            this.labelTube8.TabIndex = 207;
            this.labelTube8.Text = "0";
            this.labelTube8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTube7
            // 
            this.labelTube7.AutoSize = true;
            this.labelTube7.BackColor = System.Drawing.Color.Gray;
            this.labelTube7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTube7.Location = new System.Drawing.Point(356, 38);
            this.labelTube7.Name = "labelTube7";
            this.labelTube7.Size = new System.Drawing.Size(16, 17);
            this.labelTube7.TabIndex = 206;
            this.labelTube7.Text = "0";
            this.labelTube7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTube6
            // 
            this.labelTube6.AutoSize = true;
            this.labelTube6.BackColor = System.Drawing.Color.Gray;
            this.labelTube6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTube6.Location = new System.Drawing.Point(280, 38);
            this.labelTube6.Name = "labelTube6";
            this.labelTube6.Size = new System.Drawing.Size(16, 17);
            this.labelTube6.TabIndex = 205;
            this.labelTube6.Text = "0";
            this.labelTube6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTube5
            // 
            this.labelTube5.AutoSize = true;
            this.labelTube5.BackColor = System.Drawing.Color.Gray;
            this.labelTube5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTube5.Location = new System.Drawing.Point(208, 38);
            this.labelTube5.Name = "labelTube5";
            this.labelTube5.Size = new System.Drawing.Size(16, 17);
            this.labelTube5.TabIndex = 204;
            this.labelTube5.Text = "0";
            this.labelTube5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTube4
            // 
            this.labelTube4.AutoSize = true;
            this.labelTube4.BackColor = System.Drawing.Color.Gray;
            this.labelTube4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTube4.Location = new System.Drawing.Point(135, 38);
            this.labelTube4.Name = "labelTube4";
            this.labelTube4.Size = new System.Drawing.Size(16, 17);
            this.labelTube4.TabIndex = 203;
            this.labelTube4.Text = "0";
            this.labelTube4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTube3
            // 
            this.labelTube3.AutoSize = true;
            this.labelTube3.BackColor = System.Drawing.Color.Gray;
            this.labelTube3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTube3.Location = new System.Drawing.Point(356, 12);
            this.labelTube3.Name = "labelTube3";
            this.labelTube3.Size = new System.Drawing.Size(16, 17);
            this.labelTube3.TabIndex = 202;
            this.labelTube3.Text = "0";
            this.labelTube3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTube2
            // 
            this.labelTube2.AutoSize = true;
            this.labelTube2.BackColor = System.Drawing.Color.Gray;
            this.labelTube2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTube2.Location = new System.Drawing.Point(280, 12);
            this.labelTube2.Name = "labelTube2";
            this.labelTube2.Size = new System.Drawing.Size(16, 17);
            this.labelTube2.TabIndex = 201;
            this.labelTube2.Text = "0";
            this.labelTube2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTube1
            // 
            this.labelTube1.AutoSize = true;
            this.labelTube1.BackColor = System.Drawing.Color.Gray;
            this.labelTube1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTube1.Location = new System.Drawing.Point(208, 12);
            this.labelTube1.Name = "labelTube1";
            this.labelTube1.Size = new System.Drawing.Size(16, 17);
            this.labelTube1.TabIndex = 200;
            this.labelTube1.Text = "0";
            this.labelTube1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTube0
            // 
            this.labelTube0.AutoSize = true;
            this.labelTube0.BackColor = System.Drawing.Color.Gray;
            this.labelTube0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTube0.Location = new System.Drawing.Point(135, 12);
            this.labelTube0.Name = "labelTube0";
            this.labelTube0.Size = new System.Drawing.Size(16, 17);
            this.labelTube0.TabIndex = 199;
            this.labelTube0.Text = "0";
            this.labelTube0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabPageCoinPayoutFinal
            // 
            this.tabPageCoinPayoutFinal.BackColor = System.Drawing.Color.Tan;
            this.tabPageCoinPayoutFinal.Controls.Add(this.label26);
            this.tabPageCoinPayoutFinal.Controls.Add(this.labelGetMDBCoinPayoutFinalAckOnly);
            this.tabPageCoinPayoutFinal.Controls.Add(this.label41);
            this.tabPageCoinPayoutFinal.Controls.Add(this.label42);
            this.tabPageCoinPayoutFinal.Controls.Add(this.label43);
            this.tabPageCoinPayoutFinal.Controls.Add(this.label44);
            this.tabPageCoinPayoutFinal.Controls.Add(this.labelCoinPayoutFinal15);
            this.tabPageCoinPayoutFinal.Controls.Add(this.labelCoinPayoutFinal14);
            this.tabPageCoinPayoutFinal.Controls.Add(this.labelCoinPayoutFinal13);
            this.tabPageCoinPayoutFinal.Controls.Add(this.labelCoinPayoutFinal12);
            this.tabPageCoinPayoutFinal.Controls.Add(this.labelCoinPayoutFinal11);
            this.tabPageCoinPayoutFinal.Controls.Add(this.labelCoinPayoutFinal10);
            this.tabPageCoinPayoutFinal.Controls.Add(this.labelCoinPayoutFinal9);
            this.tabPageCoinPayoutFinal.Controls.Add(this.labelCoinPayoutFinal8);
            this.tabPageCoinPayoutFinal.Controls.Add(this.labelCoinPayoutFinal7);
            this.tabPageCoinPayoutFinal.Controls.Add(this.labelCoinPayoutFinal6);
            this.tabPageCoinPayoutFinal.Controls.Add(this.labelCoinPayoutFinal5);
            this.tabPageCoinPayoutFinal.Controls.Add(this.labelCoinPayoutFinal4);
            this.tabPageCoinPayoutFinal.Controls.Add(this.labelCoinPayoutFinal3);
            this.tabPageCoinPayoutFinal.Controls.Add(this.labelCoinPayoutFinal2);
            this.tabPageCoinPayoutFinal.Controls.Add(this.labelCoinPayoutFinal1);
            this.tabPageCoinPayoutFinal.Controls.Add(this.labelCoinPayoutFinal0);
            this.tabPageCoinPayoutFinal.Controls.Add(this.buttonGetMDBCoinPayoutFinal);
            this.tabPageCoinPayoutFinal.Controls.Add(this.labelRtnGetMDBCoinPayoutFinal);
            this.tabPageCoinPayoutFinal.Location = new System.Drawing.Point(4, 22);
            this.tabPageCoinPayoutFinal.Name = "tabPageCoinPayoutFinal";
            this.tabPageCoinPayoutFinal.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCoinPayoutFinal.Size = new System.Drawing.Size(432, 153);
            this.tabPageCoinPayoutFinal.TabIndex = 2;
            this.tabPageCoinPayoutFinal.Text = "Payout Final";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(178, 123);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(69, 13);
            this.label26.TabIndex = 246;
            this.label26.Text = "Return Value";
            // 
            // labelGetMDBCoinPayoutFinalAckOnly
            // 
            this.labelGetMDBCoinPayoutFinalAckOnly.AutoSize = true;
            this.labelGetMDBCoinPayoutFinalAckOnly.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelGetMDBCoinPayoutFinalAckOnly.Location = new System.Drawing.Point(312, 123);
            this.labelGetMDBCoinPayoutFinalAckOnly.Name = "labelGetMDBCoinPayoutFinalAckOnly";
            this.labelGetMDBCoinPayoutFinalAckOnly.Size = new System.Drawing.Size(26, 13);
            this.labelGetMDBCoinPayoutFinalAckOnly.TabIndex = 223;
            this.labelGetMDBCoinPayoutFinalAckOnly.Text = "Ack";
            this.labelGetMDBCoinPayoutFinalAckOnly.Visible = false;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.BackColor = System.Drawing.Color.Tan;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label41.Location = new System.Drawing.Point(10, 90);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(111, 17);
            this.label41.TabIndex = 245;
            this.label41.Text = "Ch12 to Ch15 ->";
            this.label41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.BackColor = System.Drawing.Color.Tan;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label42.Location = new System.Drawing.Point(18, 64);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(103, 17);
            this.label42.TabIndex = 244;
            this.label42.Text = "Ch8 to Ch11 ->";
            this.label42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.BackColor = System.Drawing.Color.Tan;
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label43.Location = new System.Drawing.Point(26, 38);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(95, 17);
            this.label43.TabIndex = 243;
            this.label43.Text = "Ch4 to Ch7 ->";
            this.label43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.BackColor = System.Drawing.Color.Tan;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label44.Location = new System.Drawing.Point(26, 12);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(95, 17);
            this.label44.TabIndex = 242;
            this.label44.Text = "Ch0 to Ch3 ->";
            this.label44.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCoinPayoutFinal15
            // 
            this.labelCoinPayoutFinal15.AutoSize = true;
            this.labelCoinPayoutFinal15.BackColor = System.Drawing.Color.Gray;
            this.labelCoinPayoutFinal15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelCoinPayoutFinal15.Location = new System.Drawing.Point(356, 90);
            this.labelCoinPayoutFinal15.Name = "labelCoinPayoutFinal15";
            this.labelCoinPayoutFinal15.Size = new System.Drawing.Size(16, 17);
            this.labelCoinPayoutFinal15.TabIndex = 241;
            this.labelCoinPayoutFinal15.Text = "0";
            this.labelCoinPayoutFinal15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCoinPayoutFinal14
            // 
            this.labelCoinPayoutFinal14.AutoSize = true;
            this.labelCoinPayoutFinal14.BackColor = System.Drawing.Color.Gray;
            this.labelCoinPayoutFinal14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelCoinPayoutFinal14.Location = new System.Drawing.Point(280, 90);
            this.labelCoinPayoutFinal14.Name = "labelCoinPayoutFinal14";
            this.labelCoinPayoutFinal14.Size = new System.Drawing.Size(16, 17);
            this.labelCoinPayoutFinal14.TabIndex = 240;
            this.labelCoinPayoutFinal14.Text = "0";
            this.labelCoinPayoutFinal14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCoinPayoutFinal13
            // 
            this.labelCoinPayoutFinal13.AutoSize = true;
            this.labelCoinPayoutFinal13.BackColor = System.Drawing.Color.Gray;
            this.labelCoinPayoutFinal13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelCoinPayoutFinal13.Location = new System.Drawing.Point(208, 90);
            this.labelCoinPayoutFinal13.Name = "labelCoinPayoutFinal13";
            this.labelCoinPayoutFinal13.Size = new System.Drawing.Size(16, 17);
            this.labelCoinPayoutFinal13.TabIndex = 239;
            this.labelCoinPayoutFinal13.Text = "0";
            this.labelCoinPayoutFinal13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCoinPayoutFinal12
            // 
            this.labelCoinPayoutFinal12.AutoSize = true;
            this.labelCoinPayoutFinal12.BackColor = System.Drawing.Color.Gray;
            this.labelCoinPayoutFinal12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelCoinPayoutFinal12.Location = new System.Drawing.Point(134, 90);
            this.labelCoinPayoutFinal12.Name = "labelCoinPayoutFinal12";
            this.labelCoinPayoutFinal12.Size = new System.Drawing.Size(16, 17);
            this.labelCoinPayoutFinal12.TabIndex = 238;
            this.labelCoinPayoutFinal12.Text = "0";
            this.labelCoinPayoutFinal12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCoinPayoutFinal11
            // 
            this.labelCoinPayoutFinal11.AutoSize = true;
            this.labelCoinPayoutFinal11.BackColor = System.Drawing.Color.Gray;
            this.labelCoinPayoutFinal11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelCoinPayoutFinal11.Location = new System.Drawing.Point(356, 64);
            this.labelCoinPayoutFinal11.Name = "labelCoinPayoutFinal11";
            this.labelCoinPayoutFinal11.Size = new System.Drawing.Size(16, 17);
            this.labelCoinPayoutFinal11.TabIndex = 237;
            this.labelCoinPayoutFinal11.Text = "0";
            this.labelCoinPayoutFinal11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCoinPayoutFinal10
            // 
            this.labelCoinPayoutFinal10.AutoSize = true;
            this.labelCoinPayoutFinal10.BackColor = System.Drawing.Color.Gray;
            this.labelCoinPayoutFinal10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelCoinPayoutFinal10.Location = new System.Drawing.Point(280, 64);
            this.labelCoinPayoutFinal10.Name = "labelCoinPayoutFinal10";
            this.labelCoinPayoutFinal10.Size = new System.Drawing.Size(16, 17);
            this.labelCoinPayoutFinal10.TabIndex = 236;
            this.labelCoinPayoutFinal10.Text = "0";
            this.labelCoinPayoutFinal10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCoinPayoutFinal9
            // 
            this.labelCoinPayoutFinal9.AutoSize = true;
            this.labelCoinPayoutFinal9.BackColor = System.Drawing.Color.Gray;
            this.labelCoinPayoutFinal9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelCoinPayoutFinal9.Location = new System.Drawing.Point(208, 64);
            this.labelCoinPayoutFinal9.Name = "labelCoinPayoutFinal9";
            this.labelCoinPayoutFinal9.Size = new System.Drawing.Size(16, 17);
            this.labelCoinPayoutFinal9.TabIndex = 235;
            this.labelCoinPayoutFinal9.Text = "0";
            this.labelCoinPayoutFinal9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCoinPayoutFinal8
            // 
            this.labelCoinPayoutFinal8.AutoSize = true;
            this.labelCoinPayoutFinal8.BackColor = System.Drawing.Color.Gray;
            this.labelCoinPayoutFinal8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelCoinPayoutFinal8.Location = new System.Drawing.Point(134, 64);
            this.labelCoinPayoutFinal8.Name = "labelCoinPayoutFinal8";
            this.labelCoinPayoutFinal8.Size = new System.Drawing.Size(16, 17);
            this.labelCoinPayoutFinal8.TabIndex = 234;
            this.labelCoinPayoutFinal8.Text = "0";
            this.labelCoinPayoutFinal8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCoinPayoutFinal7
            // 
            this.labelCoinPayoutFinal7.AutoSize = true;
            this.labelCoinPayoutFinal7.BackColor = System.Drawing.Color.Gray;
            this.labelCoinPayoutFinal7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelCoinPayoutFinal7.Location = new System.Drawing.Point(356, 38);
            this.labelCoinPayoutFinal7.Name = "labelCoinPayoutFinal7";
            this.labelCoinPayoutFinal7.Size = new System.Drawing.Size(16, 17);
            this.labelCoinPayoutFinal7.TabIndex = 233;
            this.labelCoinPayoutFinal7.Text = "0";
            this.labelCoinPayoutFinal7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCoinPayoutFinal6
            // 
            this.labelCoinPayoutFinal6.AutoSize = true;
            this.labelCoinPayoutFinal6.BackColor = System.Drawing.Color.Gray;
            this.labelCoinPayoutFinal6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelCoinPayoutFinal6.Location = new System.Drawing.Point(280, 38);
            this.labelCoinPayoutFinal6.Name = "labelCoinPayoutFinal6";
            this.labelCoinPayoutFinal6.Size = new System.Drawing.Size(16, 17);
            this.labelCoinPayoutFinal6.TabIndex = 232;
            this.labelCoinPayoutFinal6.Text = "0";
            this.labelCoinPayoutFinal6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCoinPayoutFinal5
            // 
            this.labelCoinPayoutFinal5.AutoSize = true;
            this.labelCoinPayoutFinal5.BackColor = System.Drawing.Color.Gray;
            this.labelCoinPayoutFinal5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelCoinPayoutFinal5.Location = new System.Drawing.Point(208, 38);
            this.labelCoinPayoutFinal5.Name = "labelCoinPayoutFinal5";
            this.labelCoinPayoutFinal5.Size = new System.Drawing.Size(16, 17);
            this.labelCoinPayoutFinal5.TabIndex = 231;
            this.labelCoinPayoutFinal5.Text = "0";
            this.labelCoinPayoutFinal5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCoinPayoutFinal4
            // 
            this.labelCoinPayoutFinal4.AutoSize = true;
            this.labelCoinPayoutFinal4.BackColor = System.Drawing.Color.Gray;
            this.labelCoinPayoutFinal4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelCoinPayoutFinal4.Location = new System.Drawing.Point(134, 38);
            this.labelCoinPayoutFinal4.Name = "labelCoinPayoutFinal4";
            this.labelCoinPayoutFinal4.Size = new System.Drawing.Size(16, 17);
            this.labelCoinPayoutFinal4.TabIndex = 230;
            this.labelCoinPayoutFinal4.Text = "0";
            this.labelCoinPayoutFinal4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCoinPayoutFinal3
            // 
            this.labelCoinPayoutFinal3.AutoSize = true;
            this.labelCoinPayoutFinal3.BackColor = System.Drawing.Color.Gray;
            this.labelCoinPayoutFinal3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelCoinPayoutFinal3.Location = new System.Drawing.Point(356, 12);
            this.labelCoinPayoutFinal3.Name = "labelCoinPayoutFinal3";
            this.labelCoinPayoutFinal3.Size = new System.Drawing.Size(16, 17);
            this.labelCoinPayoutFinal3.TabIndex = 229;
            this.labelCoinPayoutFinal3.Text = "0";
            this.labelCoinPayoutFinal3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCoinPayoutFinal2
            // 
            this.labelCoinPayoutFinal2.AutoSize = true;
            this.labelCoinPayoutFinal2.BackColor = System.Drawing.Color.Gray;
            this.labelCoinPayoutFinal2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelCoinPayoutFinal2.Location = new System.Drawing.Point(280, 12);
            this.labelCoinPayoutFinal2.Name = "labelCoinPayoutFinal2";
            this.labelCoinPayoutFinal2.Size = new System.Drawing.Size(16, 17);
            this.labelCoinPayoutFinal2.TabIndex = 228;
            this.labelCoinPayoutFinal2.Text = "0";
            this.labelCoinPayoutFinal2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCoinPayoutFinal1
            // 
            this.labelCoinPayoutFinal1.AutoSize = true;
            this.labelCoinPayoutFinal1.BackColor = System.Drawing.Color.Gray;
            this.labelCoinPayoutFinal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelCoinPayoutFinal1.Location = new System.Drawing.Point(208, 12);
            this.labelCoinPayoutFinal1.Name = "labelCoinPayoutFinal1";
            this.labelCoinPayoutFinal1.Size = new System.Drawing.Size(16, 17);
            this.labelCoinPayoutFinal1.TabIndex = 227;
            this.labelCoinPayoutFinal1.Text = "0";
            this.labelCoinPayoutFinal1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCoinPayoutFinal0
            // 
            this.labelCoinPayoutFinal0.AutoSize = true;
            this.labelCoinPayoutFinal0.BackColor = System.Drawing.Color.Gray;
            this.labelCoinPayoutFinal0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelCoinPayoutFinal0.Location = new System.Drawing.Point(134, 12);
            this.labelCoinPayoutFinal0.Name = "labelCoinPayoutFinal0";
            this.labelCoinPayoutFinal0.Size = new System.Drawing.Size(16, 17);
            this.labelCoinPayoutFinal0.TabIndex = 226;
            this.labelCoinPayoutFinal0.Text = "0";
            this.labelCoinPayoutFinal0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonDispenseMDBCoinsByValue
            // 
            this.buttonDispenseMDBCoinsByValue.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonDispenseMDBCoinsByValue.Location = new System.Drawing.Point(17, 634);
            this.buttonDispenseMDBCoinsByValue.Name = "buttonDispenseMDBCoinsByValue";
            this.buttonDispenseMDBCoinsByValue.Size = new System.Drawing.Size(118, 24);
            this.buttonDispenseMDBCoinsByValue.TabIndex = 224;
            this.buttonDispenseMDBCoinsByValue.Text = "Dispense Coin Value";
            this.buttonDispenseMDBCoinsByValue.UseVisualStyleBackColor = false;
            this.buttonDispenseMDBCoinsByValue.Click += new System.EventHandler(this.buttonDispenseMDBCoinsByValue_Click);
            // 
            // buttonDispenseMDBCoinsByType
            // 
            this.buttonDispenseMDBCoinsByType.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonDispenseMDBCoinsByType.Location = new System.Drawing.Point(17, 601);
            this.buttonDispenseMDBCoinsByType.Name = "buttonDispenseMDBCoinsByType";
            this.buttonDispenseMDBCoinsByType.Size = new System.Drawing.Size(118, 24);
            this.buttonDispenseMDBCoinsByType.TabIndex = 227;
            this.buttonDispenseMDBCoinsByType.Text = "Dispense Coin Type";
            this.buttonDispenseMDBCoinsByType.UseVisualStyleBackColor = false;
            this.buttonDispenseMDBCoinsByType.Click += new System.EventHandler(this.buttonDispenseMDBCoinsByType_Click);
            // 
            // labelRtnDispenseMDBCoinsByType
            // 
            this.labelRtnDispenseMDBCoinsByType.AutoSize = true;
            this.labelRtnDispenseMDBCoinsByType.BackColor = System.Drawing.Color.White;
            this.labelRtnDispenseMDBCoinsByType.Location = new System.Drawing.Point(423, 607);
            this.labelRtnDispenseMDBCoinsByType.Name = "labelRtnDispenseMDBCoinsByType";
            this.labelRtnDispenseMDBCoinsByType.Size = new System.Drawing.Size(13, 13);
            this.labelRtnDispenseMDBCoinsByType.TabIndex = 226;
            this.labelRtnDispenseMDBCoinsByType.Text = "0";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.BackColor = System.Drawing.SystemColors.Control;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label40.Location = new System.Drawing.Point(144, 605);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(25, 17);
            this.label40.TabIndex = 229;
            this.label40.Text = "Ch";
            this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.BackColor = System.Drawing.SystemColors.Control;
            this.label61.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label61.Location = new System.Drawing.Point(221, 605);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(69, 17);
            this.label61.TabIndex = 230;
            this.label61.Text = "# of coins";
            this.label61.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(348, 607);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(69, 13);
            this.label62.TabIndex = 231;
            this.label62.Text = "Return Value";
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(348, 638);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(69, 13);
            this.label63.TabIndex = 232;
            this.label63.Text = "Return Value";
            // 
            // labelPollMDBCoinPayoutString
            // 
            this.labelPollMDBCoinPayoutString.AutoSize = true;
            this.labelPollMDBCoinPayoutString.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelPollMDBCoinPayoutString.Location = new System.Drawing.Point(363, 674);
            this.labelPollMDBCoinPayoutString.Name = "labelPollMDBCoinPayoutString";
            this.labelPollMDBCoinPayoutString.Size = new System.Drawing.Size(13, 13);
            this.labelPollMDBCoinPayoutString.TabIndex = 233;
            this.labelPollMDBCoinPayoutString.Text = "0";
            // 
            // numericUpDownDispenseMDBCoinsByType1
            // 
            this.numericUpDownDispenseMDBCoinsByType1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownDispenseMDBCoinsByType1.Location = new System.Drawing.Point(171, 603);
            this.numericUpDownDispenseMDBCoinsByType1.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDownDispenseMDBCoinsByType1.Name = "numericUpDownDispenseMDBCoinsByType1";
            this.numericUpDownDispenseMDBCoinsByType1.Size = new System.Drawing.Size(44, 22);
            this.numericUpDownDispenseMDBCoinsByType1.TabIndex = 234;
            // 
            // numericUpDownDispenseMDBCoinsByType2
            // 
            this.numericUpDownDispenseMDBCoinsByType2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownDispenseMDBCoinsByType2.Location = new System.Drawing.Point(292, 603);
            this.numericUpDownDispenseMDBCoinsByType2.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDownDispenseMDBCoinsByType2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDispenseMDBCoinsByType2.Name = "numericUpDownDispenseMDBCoinsByType2";
            this.numericUpDownDispenseMDBCoinsByType2.Size = new System.Drawing.Size(50, 22);
            this.numericUpDownDispenseMDBCoinsByType2.TabIndex = 235;
            this.numericUpDownDispenseMDBCoinsByType2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownDispenseMDBCoinsByValue
            // 
            this.numericUpDownDispenseMDBCoinsByValue.DecimalPlaces = 2;
            this.numericUpDownDispenseMDBCoinsByValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownDispenseMDBCoinsByValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownDispenseMDBCoinsByValue.Location = new System.Drawing.Point(221, 634);
            this.numericUpDownDispenseMDBCoinsByValue.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericUpDownDispenseMDBCoinsByValue.Name = "numericUpDownDispenseMDBCoinsByValue";
            this.numericUpDownDispenseMDBCoinsByValue.Size = new System.Drawing.Size(81, 22);
            this.numericUpDownDispenseMDBCoinsByValue.TabIndex = 236;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(144, 636);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 237;
            this.label5.Text = "Amount $";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(14, 704);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 13);
            this.label17.TabIndex = 238;
            this.label17.Text = "Misc Replies";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(144, 674);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(69, 13);
            this.label22.TabIndex = 240;
            this.label22.Text = "Return Value";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(265, 674);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(69, 13);
            this.label23.TabIndex = 241;
            this.label23.Text = "Replied Data";
            // 
            // labelCoinStatusLightBox_Idle
            // 
            this.labelCoinStatusLightBox_Idle.AutoSize = true;
            this.labelCoinStatusLightBox_Idle.BackColor = System.Drawing.Color.Gray;
            this.labelCoinStatusLightBox_Idle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCoinStatusLightBox_Idle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCoinStatusLightBox_Idle.Location = new System.Drawing.Point(20, 320);
            this.labelCoinStatusLightBox_Idle.Name = "labelCoinStatusLightBox_Idle";
            this.labelCoinStatusLightBox_Idle.Size = new System.Drawing.Size(32, 18);
            this.labelCoinStatusLightBox_Idle.TabIndex = 242;
            this.labelCoinStatusLightBox_Idle.Text = "Idle";
            // 
            // labelCoinStatusLightBox_Reset
            // 
            this.labelCoinStatusLightBox_Reset.AutoSize = true;
            this.labelCoinStatusLightBox_Reset.BackColor = System.Drawing.Color.Gray;
            this.labelCoinStatusLightBox_Reset.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCoinStatusLightBox_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCoinStatusLightBox_Reset.Location = new System.Drawing.Point(54, 320);
            this.labelCoinStatusLightBox_Reset.Name = "labelCoinStatusLightBox_Reset";
            this.labelCoinStatusLightBox_Reset.Size = new System.Drawing.Size(46, 18);
            this.labelCoinStatusLightBox_Reset.TabIndex = 243;
            this.labelCoinStatusLightBox_Reset.Text = "Reset";
            // 
            // labelCoinStatusLightBox_Disabled
            // 
            this.labelCoinStatusLightBox_Disabled.AutoSize = true;
            this.labelCoinStatusLightBox_Disabled.BackColor = System.Drawing.Color.Gray;
            this.labelCoinStatusLightBox_Disabled.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCoinStatusLightBox_Disabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCoinStatusLightBox_Disabled.Location = new System.Drawing.Point(101, 320);
            this.labelCoinStatusLightBox_Disabled.Name = "labelCoinStatusLightBox_Disabled";
            this.labelCoinStatusLightBox_Disabled.Size = new System.Drawing.Size(65, 18);
            this.labelCoinStatusLightBox_Disabled.TabIndex = 244;
            this.labelCoinStatusLightBox_Disabled.Text = "Disabled";
            // 
            // labelCoinStatusLightBox_Cheated
            // 
            this.labelCoinStatusLightBox_Cheated.AutoSize = true;
            this.labelCoinStatusLightBox_Cheated.BackColor = System.Drawing.Color.Gray;
            this.labelCoinStatusLightBox_Cheated.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCoinStatusLightBox_Cheated.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCoinStatusLightBox_Cheated.Location = new System.Drawing.Point(168, 320);
            this.labelCoinStatusLightBox_Cheated.Name = "labelCoinStatusLightBox_Cheated";
            this.labelCoinStatusLightBox_Cheated.Size = new System.Drawing.Size(61, 18);
            this.labelCoinStatusLightBox_Cheated.TabIndex = 245;
            this.labelCoinStatusLightBox_Cheated.Text = "Cheated";
            // 
            // labelCoinStatusLightBox_Credit
            // 
            this.labelCoinStatusLightBox_Credit.AutoSize = true;
            this.labelCoinStatusLightBox_Credit.BackColor = System.Drawing.Color.Gray;
            this.labelCoinStatusLightBox_Credit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCoinStatusLightBox_Credit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCoinStatusLightBox_Credit.Location = new System.Drawing.Point(222, 345);
            this.labelCoinStatusLightBox_Credit.Name = "labelCoinStatusLightBox_Credit";
            this.labelCoinStatusLightBox_Credit.Size = new System.Drawing.Size(106, 18);
            this.labelCoinStatusLightBox_Credit.TabIndex = 246;
            this.labelCoinStatusLightBox_Credit.Text = "Credit Accepted";
            // 
            // labelCoinStatusLightBox_Manual
            // 
            this.labelCoinStatusLightBox_Manual.AutoSize = true;
            this.labelCoinStatusLightBox_Manual.BackColor = System.Drawing.Color.Gray;
            this.labelCoinStatusLightBox_Manual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCoinStatusLightBox_Manual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCoinStatusLightBox_Manual.Location = new System.Drawing.Point(292, 320);
            this.labelCoinStatusLightBox_Manual.Name = "labelCoinStatusLightBox_Manual";
            this.labelCoinStatusLightBox_Manual.Size = new System.Drawing.Size(123, 18);
            this.labelCoinStatusLightBox_Manual.TabIndex = 247;
            this.labelCoinStatusLightBox_Manual.Text = "Manual Dispensed";
            // 
            // labelCoinStatusLightBox_Jammed
            // 
            this.labelCoinStatusLightBox_Jammed.AutoSize = true;
            this.labelCoinStatusLightBox_Jammed.BackColor = System.Drawing.Color.Gray;
            this.labelCoinStatusLightBox_Jammed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCoinStatusLightBox_Jammed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCoinStatusLightBox_Jammed.Location = new System.Drawing.Point(20, 345);
            this.labelCoinStatusLightBox_Jammed.Name = "labelCoinStatusLightBox_Jammed";
            this.labelCoinStatusLightBox_Jammed.Size = new System.Drawing.Size(63, 18);
            this.labelCoinStatusLightBox_Jammed.TabIndex = 248;
            this.labelCoinStatusLightBox_Jammed.Text = "Jammed";
            // 
            // labelCoinStatusLightBox_Failure
            // 
            this.labelCoinStatusLightBox_Failure.AutoSize = true;
            this.labelCoinStatusLightBox_Failure.BackColor = System.Drawing.Color.Gray;
            this.labelCoinStatusLightBox_Failure.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCoinStatusLightBox_Failure.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCoinStatusLightBox_Failure.Location = new System.Drawing.Point(88, 345);
            this.labelCoinStatusLightBox_Failure.Name = "labelCoinStatusLightBox_Failure";
            this.labelCoinStatusLightBox_Failure.Size = new System.Drawing.Size(51, 18);
            this.labelCoinStatusLightBox_Failure.TabIndex = 249;
            this.labelCoinStatusLightBox_Failure.Text = "Failure";
            // 
            // labelCoinStatusLightBox_NoComm
            // 
            this.labelCoinStatusLightBox_NoComm.AutoSize = true;
            this.labelCoinStatusLightBox_NoComm.BackColor = System.Drawing.Color.Gray;
            this.labelCoinStatusLightBox_NoComm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCoinStatusLightBox_NoComm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCoinStatusLightBox_NoComm.Location = new System.Drawing.Point(142, 345);
            this.labelCoinStatusLightBox_NoComm.Name = "labelCoinStatusLightBox_NoComm";
            this.labelCoinStatusLightBox_NoComm.Size = new System.Drawing.Size(70, 18);
            this.labelCoinStatusLightBox_NoComm.TabIndex = 250;
            this.labelCoinStatusLightBox_NoComm.Text = "No Comm";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(18, 171);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(69, 13);
            this.label36.TabIndex = 251;
            this.label36.Text = "Return Value";
            // 
            // labelCoinStatusLightBox_CreditAmount
            // 
            this.labelCoinStatusLightBox_CreditAmount.AutoSize = true;
            this.labelCoinStatusLightBox_CreditAmount.BackColor = System.Drawing.Color.Gray;
            this.labelCoinStatusLightBox_CreditAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCoinStatusLightBox_CreditAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCoinStatusLightBox_CreditAmount.Location = new System.Drawing.Point(431, 345);
            this.labelCoinStatusLightBox_CreditAmount.Name = "labelCoinStatusLightBox_CreditAmount";
            this.labelCoinStatusLightBox_CreditAmount.Size = new System.Drawing.Size(17, 18);
            this.labelCoinStatusLightBox_CreditAmount.TabIndex = 252;
            this.labelCoinStatusLightBox_CreditAmount.Text = "0";
            // 
            // labelCoinStatusLightBox_ManualAmount
            // 
            this.labelCoinStatusLightBox_ManualAmount.AutoSize = true;
            this.labelCoinStatusLightBox_ManualAmount.BackColor = System.Drawing.Color.Gray;
            this.labelCoinStatusLightBox_ManualAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCoinStatusLightBox_ManualAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCoinStatusLightBox_ManualAmount.Location = new System.Drawing.Point(431, 320);
            this.labelCoinStatusLightBox_ManualAmount.Name = "labelCoinStatusLightBox_ManualAmount";
            this.labelCoinStatusLightBox_ManualAmount.Size = new System.Drawing.Size(17, 18);
            this.labelCoinStatusLightBox_ManualAmount.TabIndex = 253;
            this.labelCoinStatusLightBox_ManualAmount.Text = "0";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(417, 345);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(15, 16);
            this.label39.TabIndex = 254;
            this.label39.Text = "$";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.Location = new System.Drawing.Point(417, 320);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(15, 16);
            this.label45.TabIndex = 255;
            this.label45.Text = "$";
            // 
            // buttonClearCoinAmount
            // 
            this.buttonClearCoinAmount.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonClearCoinAmount.Location = new System.Drawing.Point(238, 318);
            this.buttonClearCoinAmount.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClearCoinAmount.Name = "buttonClearCoinAmount";
            this.buttonClearCoinAmount.Size = new System.Drawing.Size(39, 21);
            this.buttonClearCoinAmount.TabIndex = 256;
            this.buttonClearCoinAmount.Text = "Clear";
            this.buttonClearCoinAmount.UseVisualStyleBackColor = false;
            this.buttonClearCoinAmount.Click += new System.EventHandler(this.buttonClearCoinAmount_Click);
            // 
            // labelCoinStatusLightBox_Credit2CB
            // 
            this.labelCoinStatusLightBox_Credit2CB.AutoSize = true;
            this.labelCoinStatusLightBox_Credit2CB.BackColor = System.Drawing.Color.Gray;
            this.labelCoinStatusLightBox_Credit2CB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCoinStatusLightBox_Credit2CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCoinStatusLightBox_Credit2CB.Location = new System.Drawing.Point(330, 345);
            this.labelCoinStatusLightBox_Credit2CB.Name = "labelCoinStatusLightBox_Credit2CB";
            this.labelCoinStatusLightBox_Credit2CB.Size = new System.Drawing.Size(28, 18);
            this.labelCoinStatusLightBox_Credit2CB.TabIndex = 257;
            this.labelCoinStatusLightBox_Credit2CB.Text = "CB";
            // 
            // labelCoinStatusLightBox_Credit2TU
            // 
            this.labelCoinStatusLightBox_Credit2TU.AutoSize = true;
            this.labelCoinStatusLightBox_Credit2TU.BackColor = System.Drawing.Color.Gray;
            this.labelCoinStatusLightBox_Credit2TU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCoinStatusLightBox_Credit2TU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCoinStatusLightBox_Credit2TU.Location = new System.Drawing.Point(360, 345);
            this.labelCoinStatusLightBox_Credit2TU.Name = "labelCoinStatusLightBox_Credit2TU";
            this.labelCoinStatusLightBox_Credit2TU.Size = new System.Drawing.Size(29, 18);
            this.labelCoinStatusLightBox_Credit2TU.TabIndex = 258;
            this.labelCoinStatusLightBox_Credit2TU.Text = "TU";
            // 
            // labelCoinStatusLightBox_Credit2RJ
            // 
            this.labelCoinStatusLightBox_Credit2RJ.AutoSize = true;
            this.labelCoinStatusLightBox_Credit2RJ.BackColor = System.Drawing.Color.Gray;
            this.labelCoinStatusLightBox_Credit2RJ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCoinStatusLightBox_Credit2RJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCoinStatusLightBox_Credit2RJ.Location = new System.Drawing.Point(390, 345);
            this.labelCoinStatusLightBox_Credit2RJ.Name = "labelCoinStatusLightBox_Credit2RJ";
            this.labelCoinStatusLightBox_Credit2RJ.Size = new System.Drawing.Size(27, 18);
            this.labelCoinStatusLightBox_Credit2RJ.TabIndex = 259;
            this.labelCoinStatusLightBox_Credit2RJ.Text = "RJ";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label27.Location = new System.Drawing.Point(310, 728);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(174, 13);
            this.label27.TabIndex = 260;
            this.label27.Text = "Replied Data to specific commands";
            // 
            // labelBillStatusLightBox_Transferred
            // 
            this.labelBillStatusLightBox_Transferred.AutoSize = true;
            this.labelBillStatusLightBox_Transferred.BackColor = System.Drawing.Color.Gray;
            this.labelBillStatusLightBox_Transferred.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBillStatusLightBox_Transferred.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBillStatusLightBox_Transferred.Location = new System.Drawing.Point(776, 411);
            this.labelBillStatusLightBox_Transferred.Name = "labelBillStatusLightBox_Transferred";
            this.labelBillStatusLightBox_Transferred.Size = new System.Drawing.Size(166, 18);
            this.labelBillStatusLightBox_Transferred.TabIndex = 311;
            this.labelBillStatusLightBox_Transferred.Text = "Transferred from RE to CB";
            // 
            // labelBillStatusLightBox_Credit2RE
            // 
            this.labelBillStatusLightBox_Credit2RE.AutoSize = true;
            this.labelBillStatusLightBox_Credit2RE.BackColor = System.Drawing.Color.Gray;
            this.labelBillStatusLightBox_Credit2RE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBillStatusLightBox_Credit2RE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBillStatusLightBox_Credit2RE.Location = new System.Drawing.Point(914, 386);
            this.labelBillStatusLightBox_Credit2RE.Name = "labelBillStatusLightBox_Credit2RE";
            this.labelBillStatusLightBox_Credit2RE.Size = new System.Drawing.Size(29, 18);
            this.labelBillStatusLightBox_Credit2RE.TabIndex = 310;
            this.labelBillStatusLightBox_Credit2RE.Text = "RE";
            // 
            // labelBillStatusLightBox_Credit2CB
            // 
            this.labelBillStatusLightBox_Credit2CB.AutoSize = true;
            this.labelBillStatusLightBox_Credit2CB.BackColor = System.Drawing.Color.Gray;
            this.labelBillStatusLightBox_Credit2CB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBillStatusLightBox_Credit2CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBillStatusLightBox_Credit2CB.Location = new System.Drawing.Point(884, 386);
            this.labelBillStatusLightBox_Credit2CB.Name = "labelBillStatusLightBox_Credit2CB";
            this.labelBillStatusLightBox_Credit2CB.Size = new System.Drawing.Size(28, 18);
            this.labelBillStatusLightBox_Credit2CB.TabIndex = 309;
            this.labelBillStatusLightBox_Credit2CB.Text = "CB";
            // 
            // buttonClearBillAmount
            // 
            this.buttonClearBillAmount.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonClearBillAmount.Location = new System.Drawing.Point(776, 309);
            this.buttonClearBillAmount.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClearBillAmount.Name = "buttonClearBillAmount";
            this.buttonClearBillAmount.Size = new System.Drawing.Size(39, 21);
            this.buttonClearBillAmount.TabIndex = 308;
            this.buttonClearBillAmount.Text = "Clear";
            this.buttonClearBillAmount.UseVisualStyleBackColor = false;
            this.buttonClearBillAmount.Click += new System.EventHandler(this.buttonClearBillAmount_Click);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(944, 310);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(15, 16);
            this.label29.TabIndex = 307;
            this.label29.Text = "$";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(944, 386);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(15, 16);
            this.label30.TabIndex = 306;
            this.label30.Text = "$";
            // 
            // labelBillStatusLightBox_ManualDispensedAmount
            // 
            this.labelBillStatusLightBox_ManualDispensedAmount.AutoSize = true;
            this.labelBillStatusLightBox_ManualDispensedAmount.BackColor = System.Drawing.Color.Gray;
            this.labelBillStatusLightBox_ManualDispensedAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBillStatusLightBox_ManualDispensedAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBillStatusLightBox_ManualDispensedAmount.Location = new System.Drawing.Point(958, 310);
            this.labelBillStatusLightBox_ManualDispensedAmount.Name = "labelBillStatusLightBox_ManualDispensedAmount";
            this.labelBillStatusLightBox_ManualDispensedAmount.Size = new System.Drawing.Size(17, 18);
            this.labelBillStatusLightBox_ManualDispensedAmount.TabIndex = 305;
            this.labelBillStatusLightBox_ManualDispensedAmount.Text = "0";
            // 
            // labelBillStatusLightBox_CreditAmount
            // 
            this.labelBillStatusLightBox_CreditAmount.AutoSize = true;
            this.labelBillStatusLightBox_CreditAmount.BackColor = System.Drawing.Color.Gray;
            this.labelBillStatusLightBox_CreditAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBillStatusLightBox_CreditAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBillStatusLightBox_CreditAmount.Location = new System.Drawing.Point(958, 386);
            this.labelBillStatusLightBox_CreditAmount.Name = "labelBillStatusLightBox_CreditAmount";
            this.labelBillStatusLightBox_CreditAmount.Size = new System.Drawing.Size(17, 18);
            this.labelBillStatusLightBox_CreditAmount.TabIndex = 304;
            this.labelBillStatusLightBox_CreditAmount.Text = "0";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(512, 171);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(69, 13);
            this.label33.TabIndex = 303;
            this.label33.Text = "Return Value";
            // 
            // labelBillStatusLightBox_NoComm
            // 
            this.labelBillStatusLightBox_NoComm.AutoSize = true;
            this.labelBillStatusLightBox_NoComm.BackColor = System.Drawing.Color.Gray;
            this.labelBillStatusLightBox_NoComm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBillStatusLightBox_NoComm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBillStatusLightBox_NoComm.Location = new System.Drawing.Point(670, 411);
            this.labelBillStatusLightBox_NoComm.Name = "labelBillStatusLightBox_NoComm";
            this.labelBillStatusLightBox_NoComm.Size = new System.Drawing.Size(70, 18);
            this.labelBillStatusLightBox_NoComm.TabIndex = 302;
            this.labelBillStatusLightBox_NoComm.Text = "No Comm";
            // 
            // labelBillStatusLightBox_Failure
            // 
            this.labelBillStatusLightBox_Failure.AutoSize = true;
            this.labelBillStatusLightBox_Failure.BackColor = System.Drawing.Color.Gray;
            this.labelBillStatusLightBox_Failure.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBillStatusLightBox_Failure.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBillStatusLightBox_Failure.Location = new System.Drawing.Point(706, 386);
            this.labelBillStatusLightBox_Failure.Name = "labelBillStatusLightBox_Failure";
            this.labelBillStatusLightBox_Failure.Size = new System.Drawing.Size(51, 18);
            this.labelBillStatusLightBox_Failure.TabIndex = 301;
            this.labelBillStatusLightBox_Failure.Text = "Failure";
            // 
            // labelBillStatusLightBox_Jammed
            // 
            this.labelBillStatusLightBox_Jammed.AutoSize = true;
            this.labelBillStatusLightBox_Jammed.BackColor = System.Drawing.Color.Gray;
            this.labelBillStatusLightBox_Jammed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBillStatusLightBox_Jammed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBillStatusLightBox_Jammed.Location = new System.Drawing.Point(514, 336);
            this.labelBillStatusLightBox_Jammed.Name = "labelBillStatusLightBox_Jammed";
            this.labelBillStatusLightBox_Jammed.Size = new System.Drawing.Size(63, 18);
            this.labelBillStatusLightBox_Jammed.TabIndex = 300;
            this.labelBillStatusLightBox_Jammed.Text = "Jammed";
            // 
            // labelBillStatusLightBox_ManualDispensed
            // 
            this.labelBillStatusLightBox_ManualDispensed.AutoSize = true;
            this.labelBillStatusLightBox_ManualDispensed.BackColor = System.Drawing.Color.Gray;
            this.labelBillStatusLightBox_ManualDispensed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBillStatusLightBox_ManualDispensed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBillStatusLightBox_ManualDispensed.Location = new System.Drawing.Point(822, 310);
            this.labelBillStatusLightBox_ManualDispensed.Name = "labelBillStatusLightBox_ManualDispensed";
            this.labelBillStatusLightBox_ManualDispensed.Size = new System.Drawing.Size(123, 18);
            this.labelBillStatusLightBox_ManualDispensed.TabIndex = 299;
            this.labelBillStatusLightBox_ManualDispensed.Text = "Manual Dispensed";
            // 
            // labelBillStatusLightBox_Credit
            // 
            this.labelBillStatusLightBox_Credit.AutoSize = true;
            this.labelBillStatusLightBox_Credit.BackColor = System.Drawing.Color.Gray;
            this.labelBillStatusLightBox_Credit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBillStatusLightBox_Credit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBillStatusLightBox_Credit.Location = new System.Drawing.Point(776, 386);
            this.labelBillStatusLightBox_Credit.Name = "labelBillStatusLightBox_Credit";
            this.labelBillStatusLightBox_Credit.Size = new System.Drawing.Size(106, 18);
            this.labelBillStatusLightBox_Credit.TabIndex = 298;
            this.labelBillStatusLightBox_Credit.Text = "Credit Accepted";
            // 
            // labelBillStatusLightBox_Cheated
            // 
            this.labelBillStatusLightBox_Cheated.AutoSize = true;
            this.labelBillStatusLightBox_Cheated.BackColor = System.Drawing.Color.Gray;
            this.labelBillStatusLightBox_Cheated.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBillStatusLightBox_Cheated.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBillStatusLightBox_Cheated.Location = new System.Drawing.Point(685, 310);
            this.labelBillStatusLightBox_Cheated.Name = "labelBillStatusLightBox_Cheated";
            this.labelBillStatusLightBox_Cheated.Size = new System.Drawing.Size(61, 18);
            this.labelBillStatusLightBox_Cheated.TabIndex = 297;
            this.labelBillStatusLightBox_Cheated.Text = "Cheated";
            // 
            // labelBillStatusLightBox_Disabled
            // 
            this.labelBillStatusLightBox_Disabled.AutoSize = true;
            this.labelBillStatusLightBox_Disabled.BackColor = System.Drawing.Color.Gray;
            this.labelBillStatusLightBox_Disabled.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBillStatusLightBox_Disabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBillStatusLightBox_Disabled.Location = new System.Drawing.Point(614, 310);
            this.labelBillStatusLightBox_Disabled.Name = "labelBillStatusLightBox_Disabled";
            this.labelBillStatusLightBox_Disabled.Size = new System.Drawing.Size(65, 18);
            this.labelBillStatusLightBox_Disabled.TabIndex = 296;
            this.labelBillStatusLightBox_Disabled.Text = "Disabled";
            // 
            // labelBillStatusLightBox_Reset
            // 
            this.labelBillStatusLightBox_Reset.AutoSize = true;
            this.labelBillStatusLightBox_Reset.BackColor = System.Drawing.Color.Gray;
            this.labelBillStatusLightBox_Reset.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBillStatusLightBox_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBillStatusLightBox_Reset.Location = new System.Drawing.Point(558, 311);
            this.labelBillStatusLightBox_Reset.Name = "labelBillStatusLightBox_Reset";
            this.labelBillStatusLightBox_Reset.Size = new System.Drawing.Size(46, 18);
            this.labelBillStatusLightBox_Reset.TabIndex = 295;
            this.labelBillStatusLightBox_Reset.Text = "Reset";
            // 
            // labelBillStatusLightBox_Idle
            // 
            this.labelBillStatusLightBox_Idle.AutoSize = true;
            this.labelBillStatusLightBox_Idle.BackColor = System.Drawing.Color.Gray;
            this.labelBillStatusLightBox_Idle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBillStatusLightBox_Idle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBillStatusLightBox_Idle.Location = new System.Drawing.Point(514, 311);
            this.labelBillStatusLightBox_Idle.Name = "labelBillStatusLightBox_Idle";
            this.labelBillStatusLightBox_Idle.Size = new System.Drawing.Size(32, 18);
            this.labelBillStatusLightBox_Idle.TabIndex = 294;
            this.labelBillStatusLightBox_Idle.Text = "Idle";
            // 
            // buttonGetMDBBillSetup
            // 
            this.buttonGetMDBBillSetup.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonGetMDBBillSetup.Location = new System.Drawing.Point(509, 138);
            this.buttonGetMDBBillSetup.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGetMDBBillSetup.Name = "buttonGetMDBBillSetup";
            this.buttonGetMDBBillSetup.Size = new System.Drawing.Size(118, 24);
            this.buttonGetMDBBillSetup.TabIndex = 293;
            this.buttonGetMDBBillSetup.Text = "Get Device Setup";
            this.buttonGetMDBBillSetup.UseVisualStyleBackColor = false;
            this.buttonGetMDBBillSetup.Click += new System.EventHandler(this.buttonGetMDBBillSetup_Click);
            // 
            // labelRtnGetMDBBillSetup
            // 
            this.labelRtnGetMDBBillSetup.AutoSize = true;
            this.labelRtnGetMDBBillSetup.BackColor = System.Drawing.Color.White;
            this.labelRtnGetMDBBillSetup.Location = new System.Drawing.Point(592, 171);
            this.labelRtnGetMDBBillSetup.Name = "labelRtnGetMDBBillSetup";
            this.labelRtnGetMDBBillSetup.Size = new System.Drawing.Size(13, 13);
            this.labelRtnGetMDBBillSetup.TabIndex = 292;
            this.labelRtnGetMDBBillSetup.Text = "0";
            // 
            // labelBillISO
            // 
            this.labelBillISO.AutoSize = true;
            this.labelBillISO.BackColor = System.Drawing.Color.Gray;
            this.labelBillISO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelBillISO.Location = new System.Drawing.Point(902, 147);
            this.labelBillISO.Name = "labelBillISO";
            this.labelBillISO.Size = new System.Drawing.Size(16, 17);
            this.labelBillISO.TabIndex = 291;
            this.labelBillISO.Text = "0";
            this.labelBillISO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.BackColor = System.Drawing.SystemColors.Control;
            this.label53.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label53.Location = new System.Drawing.Point(800, 147);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(94, 17);
            this.label53.TabIndex = 290;
            this.label53.Text = "Country Code";
            this.label53.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.BackColor = System.Drawing.SystemColors.Control;
            this.label54.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label54.Location = new System.Drawing.Point(800, 168);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(97, 17);
            this.label54.TabIndex = 289;
            this.label54.Text = "Decimal Place";
            this.label54.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.BackColor = System.Drawing.SystemColors.Control;
            this.label55.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label55.Location = new System.Drawing.Point(642, 168);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(98, 17);
            this.label55.TabIndex = 288;
            this.label55.Text = "Scaling Factor";
            this.label55.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.BackColor = System.Drawing.SystemColors.Control;
            this.label56.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label56.Location = new System.Drawing.Point(642, 147);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(95, 17);
            this.label56.TabIndex = 287;
            this.label56.Text = "Feature Level";
            this.label56.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.BackColor = System.Drawing.SystemColors.Control;
            this.label57.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label57.Location = new System.Drawing.Point(524, 258);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(111, 17);
            this.label57.TabIndex = 286;
            this.label57.Text = "Ch12 to Ch15 ->";
            this.label57.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.BackColor = System.Drawing.SystemColors.Control;
            this.label58.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label58.Location = new System.Drawing.Point(532, 237);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(103, 17);
            this.label58.TabIndex = 285;
            this.label58.Text = "Ch8 to Ch11 ->";
            this.label58.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.BackColor = System.Drawing.SystemColors.Control;
            this.label59.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label59.Location = new System.Drawing.Point(539, 215);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(95, 17);
            this.label59.TabIndex = 284;
            this.label59.Text = "Ch4 to Ch7 ->";
            this.label59.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.BackColor = System.Drawing.SystemColors.Control;
            this.label60.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label60.Location = new System.Drawing.Point(539, 193);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(95, 17);
            this.label60.TabIndex = 283;
            this.label60.Text = "Ch0 to Ch3 ->";
            this.label60.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBillDecimal
            // 
            this.labelBillDecimal.AutoSize = true;
            this.labelBillDecimal.BackColor = System.Drawing.Color.Gray;
            this.labelBillDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelBillDecimal.Location = new System.Drawing.Point(902, 168);
            this.labelBillDecimal.Name = "labelBillDecimal";
            this.labelBillDecimal.Size = new System.Drawing.Size(16, 17);
            this.labelBillDecimal.TabIndex = 282;
            this.labelBillDecimal.Text = "0";
            this.labelBillDecimal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelBillScale
            // 
            this.labelBillScale.AutoSize = true;
            this.labelBillScale.BackColor = System.Drawing.Color.Gray;
            this.labelBillScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelBillScale.Location = new System.Drawing.Point(748, 168);
            this.labelBillScale.Name = "labelBillScale";
            this.labelBillScale.Size = new System.Drawing.Size(16, 17);
            this.labelBillScale.TabIndex = 281;
            this.labelBillScale.Text = "0";
            this.labelBillScale.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelBillLevel
            // 
            this.labelBillLevel.AutoSize = true;
            this.labelBillLevel.BackColor = System.Drawing.Color.Gray;
            this.labelBillLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelBillLevel.Location = new System.Drawing.Point(748, 147);
            this.labelBillLevel.Name = "labelBillLevel";
            this.labelBillLevel.Size = new System.Drawing.Size(16, 17);
            this.labelBillLevel.TabIndex = 280;
            this.labelBillLevel.Text = "0";
            this.labelBillLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelBillCh15
            // 
            this.labelBillCh15.AutoSize = true;
            this.labelBillCh15.BackColor = System.Drawing.Color.Gray;
            this.labelBillCh15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelBillCh15.Location = new System.Drawing.Point(869, 258);
            this.labelBillCh15.Name = "labelBillCh15";
            this.labelBillCh15.Size = new System.Drawing.Size(16, 17);
            this.labelBillCh15.TabIndex = 279;
            this.labelBillCh15.Text = "0";
            this.labelBillCh15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelBillCh14
            // 
            this.labelBillCh14.AutoSize = true;
            this.labelBillCh14.BackColor = System.Drawing.Color.Gray;
            this.labelBillCh14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelBillCh14.Location = new System.Drawing.Point(793, 258);
            this.labelBillCh14.Name = "labelBillCh14";
            this.labelBillCh14.Size = new System.Drawing.Size(16, 17);
            this.labelBillCh14.TabIndex = 278;
            this.labelBillCh14.Text = "0";
            this.labelBillCh14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelBillCh13
            // 
            this.labelBillCh13.AutoSize = true;
            this.labelBillCh13.BackColor = System.Drawing.Color.Gray;
            this.labelBillCh13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelBillCh13.Location = new System.Drawing.Point(721, 258);
            this.labelBillCh13.Name = "labelBillCh13";
            this.labelBillCh13.Size = new System.Drawing.Size(16, 17);
            this.labelBillCh13.TabIndex = 277;
            this.labelBillCh13.Text = "0";
            this.labelBillCh13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelBillCh12
            // 
            this.labelBillCh12.AutoSize = true;
            this.labelBillCh12.BackColor = System.Drawing.Color.Gray;
            this.labelBillCh12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelBillCh12.Location = new System.Drawing.Point(648, 258);
            this.labelBillCh12.Name = "labelBillCh12";
            this.labelBillCh12.Size = new System.Drawing.Size(16, 17);
            this.labelBillCh12.TabIndex = 276;
            this.labelBillCh12.Text = "0";
            this.labelBillCh12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelBillCh11
            // 
            this.labelBillCh11.AutoSize = true;
            this.labelBillCh11.BackColor = System.Drawing.Color.Gray;
            this.labelBillCh11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelBillCh11.Location = new System.Drawing.Point(869, 237);
            this.labelBillCh11.Name = "labelBillCh11";
            this.labelBillCh11.Size = new System.Drawing.Size(16, 17);
            this.labelBillCh11.TabIndex = 275;
            this.labelBillCh11.Text = "0";
            this.labelBillCh11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelBillCh10
            // 
            this.labelBillCh10.AutoSize = true;
            this.labelBillCh10.BackColor = System.Drawing.Color.Gray;
            this.labelBillCh10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelBillCh10.Location = new System.Drawing.Point(793, 237);
            this.labelBillCh10.Name = "labelBillCh10";
            this.labelBillCh10.Size = new System.Drawing.Size(16, 17);
            this.labelBillCh10.TabIndex = 274;
            this.labelBillCh10.Text = "0";
            this.labelBillCh10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelBillCh9
            // 
            this.labelBillCh9.AutoSize = true;
            this.labelBillCh9.BackColor = System.Drawing.Color.Gray;
            this.labelBillCh9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelBillCh9.Location = new System.Drawing.Point(721, 237);
            this.labelBillCh9.Name = "labelBillCh9";
            this.labelBillCh9.Size = new System.Drawing.Size(16, 17);
            this.labelBillCh9.TabIndex = 273;
            this.labelBillCh9.Text = "0";
            this.labelBillCh9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelBillCh8
            // 
            this.labelBillCh8.AutoSize = true;
            this.labelBillCh8.BackColor = System.Drawing.Color.Gray;
            this.labelBillCh8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelBillCh8.Location = new System.Drawing.Point(648, 237);
            this.labelBillCh8.Name = "labelBillCh8";
            this.labelBillCh8.Size = new System.Drawing.Size(16, 17);
            this.labelBillCh8.TabIndex = 272;
            this.labelBillCh8.Text = "0";
            this.labelBillCh8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelBillCh7
            // 
            this.labelBillCh7.AutoSize = true;
            this.labelBillCh7.BackColor = System.Drawing.Color.Gray;
            this.labelBillCh7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelBillCh7.Location = new System.Drawing.Point(869, 215);
            this.labelBillCh7.Name = "labelBillCh7";
            this.labelBillCh7.Size = new System.Drawing.Size(16, 17);
            this.labelBillCh7.TabIndex = 271;
            this.labelBillCh7.Text = "0";
            this.labelBillCh7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelBillCh6
            // 
            this.labelBillCh6.AutoSize = true;
            this.labelBillCh6.BackColor = System.Drawing.Color.Gray;
            this.labelBillCh6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelBillCh6.Location = new System.Drawing.Point(793, 215);
            this.labelBillCh6.Name = "labelBillCh6";
            this.labelBillCh6.Size = new System.Drawing.Size(16, 17);
            this.labelBillCh6.TabIndex = 270;
            this.labelBillCh6.Text = "0";
            this.labelBillCh6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelBillCh5
            // 
            this.labelBillCh5.AutoSize = true;
            this.labelBillCh5.BackColor = System.Drawing.Color.Gray;
            this.labelBillCh5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelBillCh5.Location = new System.Drawing.Point(721, 215);
            this.labelBillCh5.Name = "labelBillCh5";
            this.labelBillCh5.Size = new System.Drawing.Size(16, 17);
            this.labelBillCh5.TabIndex = 269;
            this.labelBillCh5.Text = "0";
            this.labelBillCh5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelBillCh4
            // 
            this.labelBillCh4.AutoSize = true;
            this.labelBillCh4.BackColor = System.Drawing.Color.Gray;
            this.labelBillCh4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelBillCh4.Location = new System.Drawing.Point(648, 215);
            this.labelBillCh4.Name = "labelBillCh4";
            this.labelBillCh4.Size = new System.Drawing.Size(16, 17);
            this.labelBillCh4.TabIndex = 268;
            this.labelBillCh4.Text = "0";
            this.labelBillCh4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelBillCh3
            // 
            this.labelBillCh3.AutoSize = true;
            this.labelBillCh3.BackColor = System.Drawing.Color.Gray;
            this.labelBillCh3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelBillCh3.Location = new System.Drawing.Point(869, 193);
            this.labelBillCh3.Name = "labelBillCh3";
            this.labelBillCh3.Size = new System.Drawing.Size(16, 17);
            this.labelBillCh3.TabIndex = 267;
            this.labelBillCh3.Text = "0";
            this.labelBillCh3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelBillCh2
            // 
            this.labelBillCh2.AutoSize = true;
            this.labelBillCh2.BackColor = System.Drawing.Color.Gray;
            this.labelBillCh2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelBillCh2.Location = new System.Drawing.Point(793, 193);
            this.labelBillCh2.Name = "labelBillCh2";
            this.labelBillCh2.Size = new System.Drawing.Size(16, 17);
            this.labelBillCh2.TabIndex = 266;
            this.labelBillCh2.Text = "0";
            this.labelBillCh2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelBillCh1
            // 
            this.labelBillCh1.AutoSize = true;
            this.labelBillCh1.BackColor = System.Drawing.Color.Gray;
            this.labelBillCh1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelBillCh1.Location = new System.Drawing.Point(721, 193);
            this.labelBillCh1.Name = "labelBillCh1";
            this.labelBillCh1.Size = new System.Drawing.Size(16, 17);
            this.labelBillCh1.TabIndex = 265;
            this.labelBillCh1.Text = "0";
            this.labelBillCh1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelBillCh0
            // 
            this.labelBillCh0.AutoSize = true;
            this.labelBillCh0.BackColor = System.Drawing.Color.Gray;
            this.labelBillCh0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelBillCh0.Location = new System.Drawing.Point(648, 193);
            this.labelBillCh0.Name = "labelBillCh0";
            this.labelBillCh0.Size = new System.Drawing.Size(16, 17);
            this.labelBillCh0.TabIndex = 264;
            this.labelBillCh0.Text = "0";
            this.labelBillCh0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.BackColor = System.Drawing.Color.Gray;
            this.label83.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label83.Location = new System.Drawing.Point(518, 311);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(0, 16);
            this.label83.TabIndex = 263;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(476, 9);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(99, 13);
            this.label52.TabIndex = 314;
            this.label52.Text = "www.moneyflex.net";
            // 
            // numericUpDownDispenseMDBBillsByValue
            // 
            this.numericUpDownDispenseMDBBillsByValue.DecimalPlaces = 2;
            this.numericUpDownDispenseMDBBillsByValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownDispenseMDBBillsByValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownDispenseMDBBillsByValue.Location = new System.Drawing.Point(720, 656);
            this.numericUpDownDispenseMDBBillsByValue.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericUpDownDispenseMDBBillsByValue.Name = "numericUpDownDispenseMDBBillsByValue";
            this.numericUpDownDispenseMDBBillsByValue.Size = new System.Drawing.Size(81, 22);
            this.numericUpDownDispenseMDBBillsByValue.TabIndex = 316;
            // 
            // labelBillStatusLightBox_Rejected
            // 
            this.labelBillStatusLightBox_Rejected.AutoSize = true;
            this.labelBillStatusLightBox_Rejected.BackColor = System.Drawing.Color.Gray;
            this.labelBillStatusLightBox_Rejected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBillStatusLightBox_Rejected.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBillStatusLightBox_Rejected.Location = new System.Drawing.Point(514, 362);
            this.labelBillStatusLightBox_Rejected.Name = "labelBillStatusLightBox_Rejected";
            this.labelBillStatusLightBox_Rejected.Size = new System.Drawing.Size(65, 18);
            this.labelBillStatusLightBox_Rejected.TabIndex = 317;
            this.labelBillStatusLightBox_Rejected.Text = "Rejected";
            // 
            // labelBillStatusLightBox_Rejecting
            // 
            this.labelBillStatusLightBox_Rejecting.AutoSize = true;
            this.labelBillStatusLightBox_Rejecting.BackColor = System.Drawing.Color.Gray;
            this.labelBillStatusLightBox_Rejecting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBillStatusLightBox_Rejecting.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBillStatusLightBox_Rejecting.Location = new System.Drawing.Point(581, 362);
            this.labelBillStatusLightBox_Rejecting.Name = "labelBillStatusLightBox_Rejecting";
            this.labelBillStatusLightBox_Rejecting.Size = new System.Drawing.Size(67, 18);
            this.labelBillStatusLightBox_Rejecting.TabIndex = 318;
            this.labelBillStatusLightBox_Rejecting.Text = "Rejecting";
            // 
            // labelBillStatusLightBox_Stacking
            // 
            this.labelBillStatusLightBox_Stacking.AutoSize = true;
            this.labelBillStatusLightBox_Stacking.BackColor = System.Drawing.Color.Gray;
            this.labelBillStatusLightBox_Stacking.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBillStatusLightBox_Stacking.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBillStatusLightBox_Stacking.Location = new System.Drawing.Point(514, 386);
            this.labelBillStatusLightBox_Stacking.Name = "labelBillStatusLightBox_Stacking";
            this.labelBillStatusLightBox_Stacking.Size = new System.Drawing.Size(62, 18);
            this.labelBillStatusLightBox_Stacking.TabIndex = 319;
            this.labelBillStatusLightBox_Stacking.Text = "Stacking";
            // 
            // labelBillStatusLightBox_CassetteProblem
            // 
            this.labelBillStatusLightBox_CassetteProblem.AutoSize = true;
            this.labelBillStatusLightBox_CassetteProblem.BackColor = System.Drawing.Color.Gray;
            this.labelBillStatusLightBox_CassetteProblem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBillStatusLightBox_CassetteProblem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBillStatusLightBox_CassetteProblem.Location = new System.Drawing.Point(685, 336);
            this.labelBillStatusLightBox_CassetteProblem.Name = "labelBillStatusLightBox_CassetteProblem";
            this.labelBillStatusLightBox_CassetteProblem.Size = new System.Drawing.Size(82, 18);
            this.labelBillStatusLightBox_CassetteProblem.TabIndex = 320;
            this.labelBillStatusLightBox_CassetteProblem.Text = "CB Problem";
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label69.Location = new System.Drawing.Point(944, 411);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(15, 16);
            this.label69.TabIndex = 323;
            this.label69.Text = "$";
            // 
            // labelBillStatusLightBox_TransferredAmount
            // 
            this.labelBillStatusLightBox_TransferredAmount.AutoSize = true;
            this.labelBillStatusLightBox_TransferredAmount.BackColor = System.Drawing.Color.Gray;
            this.labelBillStatusLightBox_TransferredAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBillStatusLightBox_TransferredAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBillStatusLightBox_TransferredAmount.Location = new System.Drawing.Point(958, 411);
            this.labelBillStatusLightBox_TransferredAmount.Name = "labelBillStatusLightBox_TransferredAmount";
            this.labelBillStatusLightBox_TransferredAmount.Size = new System.Drawing.Size(17, 18);
            this.labelBillStatusLightBox_TransferredAmount.TabIndex = 322;
            this.labelBillStatusLightBox_TransferredAmount.Text = "0";
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label71.Location = new System.Drawing.Point(944, 336);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(15, 16);
            this.label71.TabIndex = 326;
            this.label71.Text = "$";
            // 
            // labelBillStatusLightBox_EscrowedAmount
            // 
            this.labelBillStatusLightBox_EscrowedAmount.AutoSize = true;
            this.labelBillStatusLightBox_EscrowedAmount.BackColor = System.Drawing.Color.Gray;
            this.labelBillStatusLightBox_EscrowedAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBillStatusLightBox_EscrowedAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBillStatusLightBox_EscrowedAmount.Location = new System.Drawing.Point(958, 336);
            this.labelBillStatusLightBox_EscrowedAmount.Name = "labelBillStatusLightBox_EscrowedAmount";
            this.labelBillStatusLightBox_EscrowedAmount.Size = new System.Drawing.Size(17, 18);
            this.labelBillStatusLightBox_EscrowedAmount.TabIndex = 325;
            this.labelBillStatusLightBox_EscrowedAmount.Text = "0";
            // 
            // labelBillStatusLightBox_Escrowed
            // 
            this.labelBillStatusLightBox_Escrowed.AutoSize = true;
            this.labelBillStatusLightBox_Escrowed.BackColor = System.Drawing.Color.Gray;
            this.labelBillStatusLightBox_Escrowed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBillStatusLightBox_Escrowed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBillStatusLightBox_Escrowed.Location = new System.Drawing.Point(876, 336);
            this.labelBillStatusLightBox_Escrowed.Name = "labelBillStatusLightBox_Escrowed";
            this.labelBillStatusLightBox_Escrowed.Size = new System.Drawing.Size(67, 18);
            this.labelBillStatusLightBox_Escrowed.TabIndex = 324;
            this.labelBillStatusLightBox_Escrowed.Text = "In Escrow";
            // 
            // labelBillStatusLightBox_InvalidEscrow
            // 
            this.labelBillStatusLightBox_InvalidEscrow.AutoSize = true;
            this.labelBillStatusLightBox_InvalidEscrow.BackColor = System.Drawing.Color.Gray;
            this.labelBillStatusLightBox_InvalidEscrow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBillStatusLightBox_InvalidEscrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBillStatusLightBox_InvalidEscrow.Location = new System.Drawing.Point(581, 336);
            this.labelBillStatusLightBox_InvalidEscrow.Name = "labelBillStatusLightBox_InvalidEscrow";
            this.labelBillStatusLightBox_InvalidEscrow.Size = new System.Drawing.Size(96, 18);
            this.labelBillStatusLightBox_InvalidEscrow.TabIndex = 327;
            this.labelBillStatusLightBox_InvalidEscrow.Text = "Invalid Escrow";
            // 
            // checkBoxMDBBillAutoAccept
            // 
            this.checkBoxMDBBillAutoAccept.AutoSize = true;
            this.checkBoxMDBBillAutoAccept.Checked = true;
            this.checkBoxMDBBillAutoAccept.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMDBBillAutoAccept.Location = new System.Drawing.Point(778, 338);
            this.checkBoxMDBBillAutoAccept.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxMDBBillAutoAccept.Name = "checkBoxMDBBillAutoAccept";
            this.checkBoxMDBBillAutoAccept.Size = new System.Drawing.Size(48, 17);
            this.checkBoxMDBBillAutoAccept.TabIndex = 328;
            this.checkBoxMDBBillAutoAccept.Text = "Auto";
            this.checkBoxMDBBillAutoAccept.UseVisualStyleBackColor = true;
            // 
            // buttonMDBBillEscrowAccept
            // 
            this.buttonMDBBillEscrowAccept.BackColor = System.Drawing.Color.Gray;
            this.buttonMDBBillEscrowAccept.Font = new System.Drawing.Font("Wingdings", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonMDBBillEscrowAccept.Location = new System.Drawing.Point(822, 331);
            this.buttonMDBBillEscrowAccept.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMDBBillEscrowAccept.Name = "buttonMDBBillEscrowAccept";
            this.buttonMDBBillEscrowAccept.Size = new System.Drawing.Size(24, 23);
            this.buttonMDBBillEscrowAccept.TabIndex = 329;
            this.buttonMDBBillEscrowAccept.Text = "";
            this.buttonMDBBillEscrowAccept.UseVisualStyleBackColor = false;
            this.buttonMDBBillEscrowAccept.Click += new System.EventHandler(this.buttonMDBBillEscrowAccept_Click);
            // 
            // buttonMDBBillEscrowReturn
            // 
            this.buttonMDBBillEscrowReturn.BackColor = System.Drawing.Color.Gray;
            this.buttonMDBBillEscrowReturn.Font = new System.Drawing.Font("Wingdings", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonMDBBillEscrowReturn.Location = new System.Drawing.Point(848, 331);
            this.buttonMDBBillEscrowReturn.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMDBBillEscrowReturn.Name = "buttonMDBBillEscrowReturn";
            this.buttonMDBBillEscrowReturn.Size = new System.Drawing.Size(24, 23);
            this.buttonMDBBillEscrowReturn.TabIndex = 330;
            this.buttonMDBBillEscrowReturn.Text = "";
            this.buttonMDBBillEscrowReturn.UseVisualStyleBackColor = false;
            this.buttonMDBBillEscrowReturn.Click += new System.EventHandler(this.buttonMDBBillEscrowReturn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(194, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 13);
            this.label1.TabIndex = 331;
            this.label1.Text = "CB= Cashbox; TU= Tube; RJ= Reject; RE= Recycler";
            // 
            // tabPageGetRouteEnable
            // 
            this.tabPageGetRouteEnable.Controls.Add(this.tabPageSetBillEnable);
            this.tabPageGetRouteEnable.Controls.Add(this.tabPageGetBillRouteTable);
            this.tabPageGetRouteEnable.Controls.Add(this.tabPageSetBillRouteEnable);
            this.tabPageGetRouteEnable.Controls.Add(this.tabPageRecyclerContent);
            this.tabPageGetRouteEnable.Controls.Add(this.tabPageRecyclerPayoutFinal);
            this.tabPageGetRouteEnable.HotTrack = true;
            this.tabPageGetRouteEnable.Location = new System.Drawing.Point(510, 436);
            this.tabPageGetRouteEnable.Name = "tabPageGetRouteEnable";
            this.tabPageGetRouteEnable.SelectedIndex = 0;
            this.tabPageGetRouteEnable.ShowToolTips = true;
            this.tabPageGetRouteEnable.Size = new System.Drawing.Size(440, 180);
            this.tabPageGetRouteEnable.TabIndex = 332;
            // 
            // tabPageSetBillEnable
            // 
            this.tabPageSetBillEnable.BackColor = System.Drawing.Color.Tan;
            this.tabPageSetBillEnable.Controls.Add(this.label7);
            this.tabPageSetBillEnable.Controls.Add(this.buttonSetMDBBillChannels);
            this.tabPageSetBillEnable.Controls.Add(this.checkBoxBillEnable15);
            this.tabPageSetBillEnable.Controls.Add(this.checkBoxBillEnable14);
            this.tabPageSetBillEnable.Controls.Add(this.labelRtnSetMDBBillChannels);
            this.tabPageSetBillEnable.Controls.Add(this.checkBoxBillEnable13);
            this.tabPageSetBillEnable.Controls.Add(this.checkBoxBillEnable12);
            this.tabPageSetBillEnable.Controls.Add(this.checkBoxBillEnable0);
            this.tabPageSetBillEnable.Controls.Add(this.checkBoxBillEnable11);
            this.tabPageSetBillEnable.Controls.Add(this.checkBoxBillEnable1);
            this.tabPageSetBillEnable.Controls.Add(this.checkBoxBillEnable10);
            this.tabPageSetBillEnable.Controls.Add(this.checkBoxBillEnable2);
            this.tabPageSetBillEnable.Controls.Add(this.checkBoxBillEnable9);
            this.tabPageSetBillEnable.Controls.Add(this.checkBoxBillEnable3);
            this.tabPageSetBillEnable.Controls.Add(this.checkBoxBillEnable8);
            this.tabPageSetBillEnable.Controls.Add(this.checkBoxBillEnable4);
            this.tabPageSetBillEnable.Controls.Add(this.checkBoxBillEnable7);
            this.tabPageSetBillEnable.Controls.Add(this.checkBoxBillEnable5);
            this.tabPageSetBillEnable.Controls.Add(this.checkBoxBillEnable6);
            this.tabPageSetBillEnable.Location = new System.Drawing.Point(4, 22);
            this.tabPageSetBillEnable.Name = "tabPageSetBillEnable";
            this.tabPageSetBillEnable.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSetBillEnable.Size = new System.Drawing.Size(432, 154);
            this.tabPageSetBillEnable.TabIndex = 0;
            this.tabPageSetBillEnable.Text = "Channel Enable";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(181, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 241;
            this.label7.Text = "Return Value";
            // 
            // buttonSetMDBBillChannels
            // 
            this.buttonSetMDBBillChannels.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonSetMDBBillChannels.Location = new System.Drawing.Point(41, 117);
            this.buttonSetMDBBillChannels.Name = "buttonSetMDBBillChannels";
            this.buttonSetMDBBillChannels.Size = new System.Drawing.Size(118, 24);
            this.buttonSetMDBBillChannels.TabIndex = 168;
            this.buttonSetMDBBillChannels.Text = "Set Bill Enable";
            this.buttonSetMDBBillChannels.UseVisualStyleBackColor = false;
            this.buttonSetMDBBillChannels.Click += new System.EventHandler(this.buttonSetMDBBillChannels_Click);
            // 
            // checkBoxBillEnable15
            // 
            this.checkBoxBillEnable15.AutoSize = true;
            this.checkBoxBillEnable15.Checked = true;
            this.checkBoxBillEnable15.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxBillEnable15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxBillEnable15.Location = new System.Drawing.Point(289, 84);
            this.checkBoxBillEnable15.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxBillEnable15.Name = "checkBoxBillEnable15";
            this.checkBoxBillEnable15.Size = new System.Drawing.Size(57, 20);
            this.checkBoxBillEnable15.TabIndex = 222;
            this.checkBoxBillEnable15.Text = "Ch15";
            this.checkBoxBillEnable15.UseVisualStyleBackColor = true;
            // 
            // checkBoxBillEnable14
            // 
            this.checkBoxBillEnable14.AutoSize = true;
            this.checkBoxBillEnable14.Checked = true;
            this.checkBoxBillEnable14.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxBillEnable14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxBillEnable14.Location = new System.Drawing.Point(221, 84);
            this.checkBoxBillEnable14.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxBillEnable14.Name = "checkBoxBillEnable14";
            this.checkBoxBillEnable14.Size = new System.Drawing.Size(57, 20);
            this.checkBoxBillEnable14.TabIndex = 221;
            this.checkBoxBillEnable14.Text = "Ch14";
            this.checkBoxBillEnable14.UseVisualStyleBackColor = true;
            // 
            // labelRtnSetMDBBillChannels
            // 
            this.labelRtnSetMDBBillChannels.AutoSize = true;
            this.labelRtnSetMDBBillChannels.BackColor = System.Drawing.Color.White;
            this.labelRtnSetMDBBillChannels.Location = new System.Drawing.Point(265, 123);
            this.labelRtnSetMDBBillChannels.Name = "labelRtnSetMDBBillChannels";
            this.labelRtnSetMDBBillChannels.Size = new System.Drawing.Size(13, 13);
            this.labelRtnSetMDBBillChannels.TabIndex = 170;
            this.labelRtnSetMDBBillChannels.Text = "0";
            // 
            // checkBoxBillEnable13
            // 
            this.checkBoxBillEnable13.AutoSize = true;
            this.checkBoxBillEnable13.Checked = true;
            this.checkBoxBillEnable13.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxBillEnable13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxBillEnable13.Location = new System.Drawing.Point(151, 84);
            this.checkBoxBillEnable13.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxBillEnable13.Name = "checkBoxBillEnable13";
            this.checkBoxBillEnable13.Size = new System.Drawing.Size(57, 20);
            this.checkBoxBillEnable13.TabIndex = 220;
            this.checkBoxBillEnable13.Text = "Ch13";
            this.checkBoxBillEnable13.UseVisualStyleBackColor = true;
            // 
            // checkBoxBillEnable12
            // 
            this.checkBoxBillEnable12.AutoSize = true;
            this.checkBoxBillEnable12.Checked = true;
            this.checkBoxBillEnable12.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxBillEnable12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxBillEnable12.Location = new System.Drawing.Point(78, 84);
            this.checkBoxBillEnable12.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxBillEnable12.Name = "checkBoxBillEnable12";
            this.checkBoxBillEnable12.Size = new System.Drawing.Size(57, 20);
            this.checkBoxBillEnable12.TabIndex = 219;
            this.checkBoxBillEnable12.Text = "Ch12";
            this.checkBoxBillEnable12.UseVisualStyleBackColor = true;
            // 
            // checkBoxBillEnable0
            // 
            this.checkBoxBillEnable0.AutoSize = true;
            this.checkBoxBillEnable0.Checked = true;
            this.checkBoxBillEnable0.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxBillEnable0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxBillEnable0.Location = new System.Drawing.Point(78, 12);
            this.checkBoxBillEnable0.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxBillEnable0.Name = "checkBoxBillEnable0";
            this.checkBoxBillEnable0.Size = new System.Drawing.Size(50, 20);
            this.checkBoxBillEnable0.TabIndex = 207;
            this.checkBoxBillEnable0.Text = "Ch0";
            this.checkBoxBillEnable0.UseVisualStyleBackColor = true;
            // 
            // checkBoxBillEnable11
            // 
            this.checkBoxBillEnable11.AutoSize = true;
            this.checkBoxBillEnable11.Checked = true;
            this.checkBoxBillEnable11.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxBillEnable11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxBillEnable11.Location = new System.Drawing.Point(289, 60);
            this.checkBoxBillEnable11.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxBillEnable11.Name = "checkBoxBillEnable11";
            this.checkBoxBillEnable11.Size = new System.Drawing.Size(57, 20);
            this.checkBoxBillEnable11.TabIndex = 218;
            this.checkBoxBillEnable11.Text = "Ch11";
            this.checkBoxBillEnable11.UseVisualStyleBackColor = true;
            // 
            // checkBoxBillEnable1
            // 
            this.checkBoxBillEnable1.AutoSize = true;
            this.checkBoxBillEnable1.Checked = true;
            this.checkBoxBillEnable1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxBillEnable1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxBillEnable1.Location = new System.Drawing.Point(150, 12);
            this.checkBoxBillEnable1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxBillEnable1.Name = "checkBoxBillEnable1";
            this.checkBoxBillEnable1.Size = new System.Drawing.Size(50, 20);
            this.checkBoxBillEnable1.TabIndex = 208;
            this.checkBoxBillEnable1.Text = "Ch1";
            this.checkBoxBillEnable1.UseVisualStyleBackColor = true;
            // 
            // checkBoxBillEnable10
            // 
            this.checkBoxBillEnable10.AutoSize = true;
            this.checkBoxBillEnable10.Checked = true;
            this.checkBoxBillEnable10.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxBillEnable10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxBillEnable10.Location = new System.Drawing.Point(221, 60);
            this.checkBoxBillEnable10.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxBillEnable10.Name = "checkBoxBillEnable10";
            this.checkBoxBillEnable10.Size = new System.Drawing.Size(57, 20);
            this.checkBoxBillEnable10.TabIndex = 217;
            this.checkBoxBillEnable10.Text = "Ch10";
            this.checkBoxBillEnable10.UseVisualStyleBackColor = true;
            // 
            // checkBoxBillEnable2
            // 
            this.checkBoxBillEnable2.AutoSize = true;
            this.checkBoxBillEnable2.Checked = true;
            this.checkBoxBillEnable2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxBillEnable2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxBillEnable2.Location = new System.Drawing.Point(221, 12);
            this.checkBoxBillEnable2.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxBillEnable2.Name = "checkBoxBillEnable2";
            this.checkBoxBillEnable2.Size = new System.Drawing.Size(50, 20);
            this.checkBoxBillEnable2.TabIndex = 209;
            this.checkBoxBillEnable2.Text = "Ch2";
            this.checkBoxBillEnable2.UseVisualStyleBackColor = true;
            // 
            // checkBoxBillEnable9
            // 
            this.checkBoxBillEnable9.AutoSize = true;
            this.checkBoxBillEnable9.Checked = true;
            this.checkBoxBillEnable9.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxBillEnable9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxBillEnable9.Location = new System.Drawing.Point(151, 60);
            this.checkBoxBillEnable9.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxBillEnable9.Name = "checkBoxBillEnable9";
            this.checkBoxBillEnable9.Size = new System.Drawing.Size(50, 20);
            this.checkBoxBillEnable9.TabIndex = 216;
            this.checkBoxBillEnable9.Text = "Ch9";
            this.checkBoxBillEnable9.UseVisualStyleBackColor = true;
            // 
            // checkBoxBillEnable3
            // 
            this.checkBoxBillEnable3.AutoSize = true;
            this.checkBoxBillEnable3.Checked = true;
            this.checkBoxBillEnable3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxBillEnable3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxBillEnable3.Location = new System.Drawing.Point(289, 12);
            this.checkBoxBillEnable3.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxBillEnable3.Name = "checkBoxBillEnable3";
            this.checkBoxBillEnable3.Size = new System.Drawing.Size(50, 20);
            this.checkBoxBillEnable3.TabIndex = 210;
            this.checkBoxBillEnable3.Text = "Ch3";
            this.checkBoxBillEnable3.UseVisualStyleBackColor = true;
            // 
            // checkBoxBillEnable8
            // 
            this.checkBoxBillEnable8.AutoSize = true;
            this.checkBoxBillEnable8.Checked = true;
            this.checkBoxBillEnable8.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxBillEnable8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxBillEnable8.Location = new System.Drawing.Point(78, 60);
            this.checkBoxBillEnable8.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxBillEnable8.Name = "checkBoxBillEnable8";
            this.checkBoxBillEnable8.Size = new System.Drawing.Size(50, 20);
            this.checkBoxBillEnable8.TabIndex = 215;
            this.checkBoxBillEnable8.Text = "Ch8";
            this.checkBoxBillEnable8.UseVisualStyleBackColor = true;
            // 
            // checkBoxBillEnable4
            // 
            this.checkBoxBillEnable4.AutoSize = true;
            this.checkBoxBillEnable4.Checked = true;
            this.checkBoxBillEnable4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxBillEnable4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxBillEnable4.Location = new System.Drawing.Point(78, 36);
            this.checkBoxBillEnable4.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxBillEnable4.Name = "checkBoxBillEnable4";
            this.checkBoxBillEnable4.Size = new System.Drawing.Size(50, 20);
            this.checkBoxBillEnable4.TabIndex = 211;
            this.checkBoxBillEnable4.Text = "Ch4";
            this.checkBoxBillEnable4.UseVisualStyleBackColor = true;
            // 
            // checkBoxBillEnable7
            // 
            this.checkBoxBillEnable7.AutoSize = true;
            this.checkBoxBillEnable7.Checked = true;
            this.checkBoxBillEnable7.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxBillEnable7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxBillEnable7.Location = new System.Drawing.Point(289, 36);
            this.checkBoxBillEnable7.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxBillEnable7.Name = "checkBoxBillEnable7";
            this.checkBoxBillEnable7.Size = new System.Drawing.Size(50, 20);
            this.checkBoxBillEnable7.TabIndex = 214;
            this.checkBoxBillEnable7.Text = "Ch7";
            this.checkBoxBillEnable7.UseVisualStyleBackColor = true;
            // 
            // checkBoxBillEnable5
            // 
            this.checkBoxBillEnable5.AutoSize = true;
            this.checkBoxBillEnable5.Checked = true;
            this.checkBoxBillEnable5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxBillEnable5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxBillEnable5.Location = new System.Drawing.Point(151, 36);
            this.checkBoxBillEnable5.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxBillEnable5.Name = "checkBoxBillEnable5";
            this.checkBoxBillEnable5.Size = new System.Drawing.Size(50, 20);
            this.checkBoxBillEnable5.TabIndex = 212;
            this.checkBoxBillEnable5.Text = "Ch5";
            this.checkBoxBillEnable5.UseVisualStyleBackColor = true;
            // 
            // checkBoxBillEnable6
            // 
            this.checkBoxBillEnable6.AutoSize = true;
            this.checkBoxBillEnable6.Checked = true;
            this.checkBoxBillEnable6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxBillEnable6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxBillEnable6.Location = new System.Drawing.Point(221, 36);
            this.checkBoxBillEnable6.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxBillEnable6.Name = "checkBoxBillEnable6";
            this.checkBoxBillEnable6.Size = new System.Drawing.Size(50, 20);
            this.checkBoxBillEnable6.TabIndex = 213;
            this.checkBoxBillEnable6.Text = "Ch6";
            this.checkBoxBillEnable6.UseVisualStyleBackColor = true;
            // 
            // tabPageGetBillRouteTable
            // 
            this.tabPageGetBillRouteTable.BackColor = System.Drawing.Color.Tan;
            this.tabPageGetBillRouteTable.Controls.Add(this.label31);
            this.tabPageGetBillRouteTable.Controls.Add(this.labelRtnGetMDBRecyclerRouteTable);
            this.tabPageGetBillRouteTable.Controls.Add(this.buttonGetMDBRecyclerRouteTable);
            this.tabPageGetBillRouteTable.Controls.Add(this.label34);
            this.tabPageGetBillRouteTable.Controls.Add(this.label35);
            this.tabPageGetBillRouteTable.Controls.Add(this.label37);
            this.tabPageGetBillRouteTable.Controls.Add(this.label38);
            this.tabPageGetBillRouteTable.Controls.Add(this.labelRouteTable15);
            this.tabPageGetBillRouteTable.Controls.Add(this.labelRouteTable14);
            this.tabPageGetBillRouteTable.Controls.Add(this.labelRouteTable13);
            this.tabPageGetBillRouteTable.Controls.Add(this.labelRouteTable12);
            this.tabPageGetBillRouteTable.Controls.Add(this.labelRouteTable11);
            this.tabPageGetBillRouteTable.Controls.Add(this.labelRouteTable10);
            this.tabPageGetBillRouteTable.Controls.Add(this.labelRouteTable9);
            this.tabPageGetBillRouteTable.Controls.Add(this.labelRouteTable8);
            this.tabPageGetBillRouteTable.Controls.Add(this.labelRouteTable7);
            this.tabPageGetBillRouteTable.Controls.Add(this.labelRouteTable6);
            this.tabPageGetBillRouteTable.Controls.Add(this.labelRouteTable5);
            this.tabPageGetBillRouteTable.Controls.Add(this.labelRouteTable4);
            this.tabPageGetBillRouteTable.Controls.Add(this.labelRouteTable3);
            this.tabPageGetBillRouteTable.Controls.Add(this.labelRouteTable2);
            this.tabPageGetBillRouteTable.Controls.Add(this.labelRouteTable1);
            this.tabPageGetBillRouteTable.Controls.Add(this.labelRouteTable0);
            this.tabPageGetBillRouteTable.Location = new System.Drawing.Point(4, 22);
            this.tabPageGetBillRouteTable.Name = "tabPageGetBillRouteTable";
            this.tabPageGetBillRouteTable.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGetBillRouteTable.Size = new System.Drawing.Size(432, 154);
            this.tabPageGetBillRouteTable.TabIndex = 1;
            this.tabPageGetBillRouteTable.Text = "Route Table";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(182, 124);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(69, 13);
            this.label31.TabIndex = 241;
            this.label31.Text = "Return Value";
            // 
            // labelRtnGetMDBRecyclerRouteTable
            // 
            this.labelRtnGetMDBRecyclerRouteTable.AutoSize = true;
            this.labelRtnGetMDBRecyclerRouteTable.BackColor = System.Drawing.Color.White;
            this.labelRtnGetMDBRecyclerRouteTable.Location = new System.Drawing.Point(266, 124);
            this.labelRtnGetMDBRecyclerRouteTable.Name = "labelRtnGetMDBRecyclerRouteTable";
            this.labelRtnGetMDBRecyclerRouteTable.Size = new System.Drawing.Size(13, 13);
            this.labelRtnGetMDBRecyclerRouteTable.TabIndex = 224;
            this.labelRtnGetMDBRecyclerRouteTable.Text = "0";
            // 
            // buttonGetMDBRecyclerRouteTable
            // 
            this.buttonGetMDBRecyclerRouteTable.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonGetMDBRecyclerRouteTable.Location = new System.Drawing.Point(41, 118);
            this.buttonGetMDBRecyclerRouteTable.Name = "buttonGetMDBRecyclerRouteTable";
            this.buttonGetMDBRecyclerRouteTable.Size = new System.Drawing.Size(118, 24);
            this.buttonGetMDBRecyclerRouteTable.TabIndex = 219;
            this.buttonGetMDBRecyclerRouteTable.Text = "Get Route Table";
            this.buttonGetMDBRecyclerRouteTable.UseVisualStyleBackColor = false;
            this.buttonGetMDBRecyclerRouteTable.Click += new System.EventHandler(this.buttonGetMDBRecyclerRouteTable_Click);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.BackColor = System.Drawing.Color.Tan;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label34.Location = new System.Drawing.Point(20, 90);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(111, 17);
            this.label34.TabIndex = 218;
            this.label34.Text = "Ch12 to Ch15 ->";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.BackColor = System.Drawing.Color.Tan;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label35.Location = new System.Drawing.Point(28, 64);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(103, 17);
            this.label35.TabIndex = 217;
            this.label35.Text = "Ch8 to Ch11 ->";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.BackColor = System.Drawing.Color.Tan;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label37.Location = new System.Drawing.Point(36, 38);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(95, 17);
            this.label37.TabIndex = 216;
            this.label37.Text = "Ch4 to Ch7 ->";
            this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.BackColor = System.Drawing.Color.Tan;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label38.Location = new System.Drawing.Point(36, 12);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(95, 17);
            this.label38.TabIndex = 215;
            this.label38.Text = "Ch0 to Ch3 ->";
            this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRouteTable15
            // 
            this.labelRouteTable15.AutoSize = true;
            this.labelRouteTable15.BackColor = System.Drawing.Color.Gray;
            this.labelRouteTable15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelRouteTable15.Location = new System.Drawing.Point(366, 90);
            this.labelRouteTable15.Name = "labelRouteTable15";
            this.labelRouteTable15.Size = new System.Drawing.Size(16, 17);
            this.labelRouteTable15.TabIndex = 214;
            this.labelRouteTable15.Text = "0";
            this.labelRouteTable15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRouteTable14
            // 
            this.labelRouteTable14.AutoSize = true;
            this.labelRouteTable14.BackColor = System.Drawing.Color.Gray;
            this.labelRouteTable14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelRouteTable14.Location = new System.Drawing.Point(290, 90);
            this.labelRouteTable14.Name = "labelRouteTable14";
            this.labelRouteTable14.Size = new System.Drawing.Size(16, 17);
            this.labelRouteTable14.TabIndex = 213;
            this.labelRouteTable14.Text = "0";
            this.labelRouteTable14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRouteTable13
            // 
            this.labelRouteTable13.AutoSize = true;
            this.labelRouteTable13.BackColor = System.Drawing.Color.Gray;
            this.labelRouteTable13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelRouteTable13.Location = new System.Drawing.Point(218, 90);
            this.labelRouteTable13.Name = "labelRouteTable13";
            this.labelRouteTable13.Size = new System.Drawing.Size(16, 17);
            this.labelRouteTable13.TabIndex = 212;
            this.labelRouteTable13.Text = "0";
            this.labelRouteTable13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRouteTable12
            // 
            this.labelRouteTable12.AutoSize = true;
            this.labelRouteTable12.BackColor = System.Drawing.Color.Gray;
            this.labelRouteTable12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelRouteTable12.Location = new System.Drawing.Point(144, 90);
            this.labelRouteTable12.Name = "labelRouteTable12";
            this.labelRouteTable12.Size = new System.Drawing.Size(16, 17);
            this.labelRouteTable12.TabIndex = 211;
            this.labelRouteTable12.Text = "0";
            this.labelRouteTable12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRouteTable11
            // 
            this.labelRouteTable11.AutoSize = true;
            this.labelRouteTable11.BackColor = System.Drawing.Color.Gray;
            this.labelRouteTable11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelRouteTable11.Location = new System.Drawing.Point(366, 64);
            this.labelRouteTable11.Name = "labelRouteTable11";
            this.labelRouteTable11.Size = new System.Drawing.Size(16, 17);
            this.labelRouteTable11.TabIndex = 210;
            this.labelRouteTable11.Text = "0";
            this.labelRouteTable11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRouteTable10
            // 
            this.labelRouteTable10.AutoSize = true;
            this.labelRouteTable10.BackColor = System.Drawing.Color.Gray;
            this.labelRouteTable10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelRouteTable10.Location = new System.Drawing.Point(290, 64);
            this.labelRouteTable10.Name = "labelRouteTable10";
            this.labelRouteTable10.Size = new System.Drawing.Size(16, 17);
            this.labelRouteTable10.TabIndex = 209;
            this.labelRouteTable10.Text = "0";
            this.labelRouteTable10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRouteTable9
            // 
            this.labelRouteTable9.AutoSize = true;
            this.labelRouteTable9.BackColor = System.Drawing.Color.Gray;
            this.labelRouteTable9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelRouteTable9.Location = new System.Drawing.Point(218, 64);
            this.labelRouteTable9.Name = "labelRouteTable9";
            this.labelRouteTable9.Size = new System.Drawing.Size(16, 17);
            this.labelRouteTable9.TabIndex = 208;
            this.labelRouteTable9.Text = "0";
            this.labelRouteTable9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRouteTable8
            // 
            this.labelRouteTable8.AutoSize = true;
            this.labelRouteTable8.BackColor = System.Drawing.Color.Gray;
            this.labelRouteTable8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelRouteTable8.Location = new System.Drawing.Point(144, 64);
            this.labelRouteTable8.Name = "labelRouteTable8";
            this.labelRouteTable8.Size = new System.Drawing.Size(16, 17);
            this.labelRouteTable8.TabIndex = 207;
            this.labelRouteTable8.Text = "0";
            this.labelRouteTable8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRouteTable7
            // 
            this.labelRouteTable7.AutoSize = true;
            this.labelRouteTable7.BackColor = System.Drawing.Color.Gray;
            this.labelRouteTable7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelRouteTable7.Location = new System.Drawing.Point(366, 38);
            this.labelRouteTable7.Name = "labelRouteTable7";
            this.labelRouteTable7.Size = new System.Drawing.Size(16, 17);
            this.labelRouteTable7.TabIndex = 206;
            this.labelRouteTable7.Text = "0";
            this.labelRouteTable7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRouteTable6
            // 
            this.labelRouteTable6.AutoSize = true;
            this.labelRouteTable6.BackColor = System.Drawing.Color.Gray;
            this.labelRouteTable6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelRouteTable6.Location = new System.Drawing.Point(290, 38);
            this.labelRouteTable6.Name = "labelRouteTable6";
            this.labelRouteTable6.Size = new System.Drawing.Size(16, 17);
            this.labelRouteTable6.TabIndex = 205;
            this.labelRouteTable6.Text = "0";
            this.labelRouteTable6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRouteTable5
            // 
            this.labelRouteTable5.AutoSize = true;
            this.labelRouteTable5.BackColor = System.Drawing.Color.Gray;
            this.labelRouteTable5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelRouteTable5.Location = new System.Drawing.Point(218, 38);
            this.labelRouteTable5.Name = "labelRouteTable5";
            this.labelRouteTable5.Size = new System.Drawing.Size(16, 17);
            this.labelRouteTable5.TabIndex = 204;
            this.labelRouteTable5.Text = "0";
            this.labelRouteTable5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRouteTable4
            // 
            this.labelRouteTable4.AutoSize = true;
            this.labelRouteTable4.BackColor = System.Drawing.Color.Gray;
            this.labelRouteTable4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelRouteTable4.Location = new System.Drawing.Point(144, 38);
            this.labelRouteTable4.Name = "labelRouteTable4";
            this.labelRouteTable4.Size = new System.Drawing.Size(16, 17);
            this.labelRouteTable4.TabIndex = 203;
            this.labelRouteTable4.Text = "0";
            this.labelRouteTable4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRouteTable3
            // 
            this.labelRouteTable3.AutoSize = true;
            this.labelRouteTable3.BackColor = System.Drawing.Color.Gray;
            this.labelRouteTable3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelRouteTable3.Location = new System.Drawing.Point(366, 12);
            this.labelRouteTable3.Name = "labelRouteTable3";
            this.labelRouteTable3.Size = new System.Drawing.Size(16, 17);
            this.labelRouteTable3.TabIndex = 202;
            this.labelRouteTable3.Text = "0";
            this.labelRouteTable3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRouteTable2
            // 
            this.labelRouteTable2.AutoSize = true;
            this.labelRouteTable2.BackColor = System.Drawing.Color.Gray;
            this.labelRouteTable2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelRouteTable2.Location = new System.Drawing.Point(290, 12);
            this.labelRouteTable2.Name = "labelRouteTable2";
            this.labelRouteTable2.Size = new System.Drawing.Size(16, 17);
            this.labelRouteTable2.TabIndex = 201;
            this.labelRouteTable2.Text = "0";
            this.labelRouteTable2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRouteTable1
            // 
            this.labelRouteTable1.AutoSize = true;
            this.labelRouteTable1.BackColor = System.Drawing.Color.Gray;
            this.labelRouteTable1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelRouteTable1.Location = new System.Drawing.Point(218, 12);
            this.labelRouteTable1.Name = "labelRouteTable1";
            this.labelRouteTable1.Size = new System.Drawing.Size(16, 17);
            this.labelRouteTable1.TabIndex = 200;
            this.labelRouteTable1.Text = "0";
            this.labelRouteTable1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRouteTable0
            // 
            this.labelRouteTable0.AutoSize = true;
            this.labelRouteTable0.BackColor = System.Drawing.Color.Gray;
            this.labelRouteTable0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelRouteTable0.Location = new System.Drawing.Point(144, 12);
            this.labelRouteTable0.Name = "labelRouteTable0";
            this.labelRouteTable0.Size = new System.Drawing.Size(16, 17);
            this.labelRouteTable0.TabIndex = 199;
            this.labelRouteTable0.Text = "0";
            this.labelRouteTable0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabPageSetBillRouteEnable
            // 
            this.tabPageSetBillRouteEnable.BackColor = System.Drawing.Color.Tan;
            this.tabPageSetBillRouteEnable.Controls.Add(this.label78);
            this.tabPageSetBillRouteEnable.Controls.Add(this.buttonSetMDBRecyclerRouteEnable);
            this.tabPageSetBillRouteEnable.Controls.Add(this.checkBoxRouteEnable15);
            this.tabPageSetBillRouteEnable.Controls.Add(this.checkBoxRouteEnable14);
            this.tabPageSetBillRouteEnable.Controls.Add(this.labelRtnSetMDBRecyclerRouteEnable);
            this.tabPageSetBillRouteEnable.Controls.Add(this.checkBoxRouteEnable13);
            this.tabPageSetBillRouteEnable.Controls.Add(this.checkBoxRouteEnable12);
            this.tabPageSetBillRouteEnable.Controls.Add(this.checkBoxRouteEnable0);
            this.tabPageSetBillRouteEnable.Controls.Add(this.checkBoxRouteEnable11);
            this.tabPageSetBillRouteEnable.Controls.Add(this.checkBoxRouteEnable1);
            this.tabPageSetBillRouteEnable.Controls.Add(this.checkBoxRouteEnable10);
            this.tabPageSetBillRouteEnable.Controls.Add(this.checkBoxRouteEnable2);
            this.tabPageSetBillRouteEnable.Controls.Add(this.checkBoxRouteEnable9);
            this.tabPageSetBillRouteEnable.Controls.Add(this.checkBoxRouteEnable3);
            this.tabPageSetBillRouteEnable.Controls.Add(this.checkBoxRouteEnable8);
            this.tabPageSetBillRouteEnable.Controls.Add(this.checkBoxRouteEnable4);
            this.tabPageSetBillRouteEnable.Controls.Add(this.checkBoxRouteEnable7);
            this.tabPageSetBillRouteEnable.Controls.Add(this.checkBoxRouteEnable5);
            this.tabPageSetBillRouteEnable.Controls.Add(this.checkBoxRouteEnable6);
            this.tabPageSetBillRouteEnable.Location = new System.Drawing.Point(4, 22);
            this.tabPageSetBillRouteEnable.Name = "tabPageSetBillRouteEnable";
            this.tabPageSetBillRouteEnable.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSetBillRouteEnable.Size = new System.Drawing.Size(432, 154);
            this.tabPageSetBillRouteEnable.TabIndex = 2;
            this.tabPageSetBillRouteEnable.Text = "Route Enable";
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Location = new System.Drawing.Point(174, 124);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(69, 13);
            this.label78.TabIndex = 262;
            this.label78.Text = "Return Value";
            // 
            // buttonSetMDBRecyclerRouteEnable
            // 
            this.buttonSetMDBRecyclerRouteEnable.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonSetMDBRecyclerRouteEnable.Location = new System.Drawing.Point(39, 118);
            this.buttonSetMDBRecyclerRouteEnable.Name = "buttonSetMDBRecyclerRouteEnable";
            this.buttonSetMDBRecyclerRouteEnable.Size = new System.Drawing.Size(118, 24);
            this.buttonSetMDBRecyclerRouteEnable.TabIndex = 244;
            this.buttonSetMDBRecyclerRouteEnable.Text = "Set Route Enable";
            this.buttonSetMDBRecyclerRouteEnable.UseVisualStyleBackColor = false;
            this.buttonSetMDBRecyclerRouteEnable.Click += new System.EventHandler(this.buttonSetMDBRecyclerRouteEnable_Click);
            // 
            // checkBoxRouteEnable15
            // 
            this.checkBoxRouteEnable15.AutoSize = true;
            this.checkBoxRouteEnable15.Checked = true;
            this.checkBoxRouteEnable15.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRouteEnable15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRouteEnable15.Location = new System.Drawing.Point(290, 84);
            this.checkBoxRouteEnable15.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxRouteEnable15.Name = "checkBoxRouteEnable15";
            this.checkBoxRouteEnable15.Size = new System.Drawing.Size(57, 20);
            this.checkBoxRouteEnable15.TabIndex = 261;
            this.checkBoxRouteEnable15.Text = "Ch15";
            this.checkBoxRouteEnable15.UseVisualStyleBackColor = true;
            // 
            // checkBoxRouteEnable14
            // 
            this.checkBoxRouteEnable14.AutoSize = true;
            this.checkBoxRouteEnable14.Checked = true;
            this.checkBoxRouteEnable14.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRouteEnable14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRouteEnable14.Location = new System.Drawing.Point(222, 84);
            this.checkBoxRouteEnable14.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxRouteEnable14.Name = "checkBoxRouteEnable14";
            this.checkBoxRouteEnable14.Size = new System.Drawing.Size(57, 20);
            this.checkBoxRouteEnable14.TabIndex = 260;
            this.checkBoxRouteEnable14.Text = "Ch14";
            this.checkBoxRouteEnable14.UseVisualStyleBackColor = true;
            // 
            // labelRtnSetMDBRecyclerRouteEnable
            // 
            this.labelRtnSetMDBRecyclerRouteEnable.AutoSize = true;
            this.labelRtnSetMDBRecyclerRouteEnable.BackColor = System.Drawing.Color.White;
            this.labelRtnSetMDBRecyclerRouteEnable.Location = new System.Drawing.Point(258, 124);
            this.labelRtnSetMDBRecyclerRouteEnable.Name = "labelRtnSetMDBRecyclerRouteEnable";
            this.labelRtnSetMDBRecyclerRouteEnable.Size = new System.Drawing.Size(13, 13);
            this.labelRtnSetMDBRecyclerRouteEnable.TabIndex = 245;
            this.labelRtnSetMDBRecyclerRouteEnable.Text = "0";
            // 
            // checkBoxRouteEnable13
            // 
            this.checkBoxRouteEnable13.AutoSize = true;
            this.checkBoxRouteEnable13.Checked = true;
            this.checkBoxRouteEnable13.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRouteEnable13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRouteEnable13.Location = new System.Drawing.Point(152, 84);
            this.checkBoxRouteEnable13.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxRouteEnable13.Name = "checkBoxRouteEnable13";
            this.checkBoxRouteEnable13.Size = new System.Drawing.Size(57, 20);
            this.checkBoxRouteEnable13.TabIndex = 259;
            this.checkBoxRouteEnable13.Text = "Ch13";
            this.checkBoxRouteEnable13.UseVisualStyleBackColor = true;
            // 
            // checkBoxRouteEnable12
            // 
            this.checkBoxRouteEnable12.AutoSize = true;
            this.checkBoxRouteEnable12.Checked = true;
            this.checkBoxRouteEnable12.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRouteEnable12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRouteEnable12.Location = new System.Drawing.Point(78, 84);
            this.checkBoxRouteEnable12.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxRouteEnable12.Name = "checkBoxRouteEnable12";
            this.checkBoxRouteEnable12.Size = new System.Drawing.Size(57, 20);
            this.checkBoxRouteEnable12.TabIndex = 258;
            this.checkBoxRouteEnable12.Text = "Ch12";
            this.checkBoxRouteEnable12.UseVisualStyleBackColor = true;
            // 
            // checkBoxRouteEnable0
            // 
            this.checkBoxRouteEnable0.AutoSize = true;
            this.checkBoxRouteEnable0.Checked = true;
            this.checkBoxRouteEnable0.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRouteEnable0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRouteEnable0.Location = new System.Drawing.Point(78, 12);
            this.checkBoxRouteEnable0.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxRouteEnable0.Name = "checkBoxRouteEnable0";
            this.checkBoxRouteEnable0.Size = new System.Drawing.Size(50, 20);
            this.checkBoxRouteEnable0.TabIndex = 246;
            this.checkBoxRouteEnable0.Text = "Ch0";
            this.checkBoxRouteEnable0.UseVisualStyleBackColor = true;
            // 
            // checkBoxRouteEnable11
            // 
            this.checkBoxRouteEnable11.AutoSize = true;
            this.checkBoxRouteEnable11.Checked = true;
            this.checkBoxRouteEnable11.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRouteEnable11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRouteEnable11.Location = new System.Drawing.Point(290, 60);
            this.checkBoxRouteEnable11.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxRouteEnable11.Name = "checkBoxRouteEnable11";
            this.checkBoxRouteEnable11.Size = new System.Drawing.Size(57, 20);
            this.checkBoxRouteEnable11.TabIndex = 257;
            this.checkBoxRouteEnable11.Text = "Ch11";
            this.checkBoxRouteEnable11.UseVisualStyleBackColor = true;
            // 
            // checkBoxRouteEnable1
            // 
            this.checkBoxRouteEnable1.AutoSize = true;
            this.checkBoxRouteEnable1.Checked = true;
            this.checkBoxRouteEnable1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRouteEnable1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRouteEnable1.Location = new System.Drawing.Point(150, 12);
            this.checkBoxRouteEnable1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxRouteEnable1.Name = "checkBoxRouteEnable1";
            this.checkBoxRouteEnable1.Size = new System.Drawing.Size(50, 20);
            this.checkBoxRouteEnable1.TabIndex = 247;
            this.checkBoxRouteEnable1.Text = "Ch1";
            this.checkBoxRouteEnable1.UseVisualStyleBackColor = true;
            // 
            // checkBoxRouteEnable10
            // 
            this.checkBoxRouteEnable10.AutoSize = true;
            this.checkBoxRouteEnable10.Checked = true;
            this.checkBoxRouteEnable10.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRouteEnable10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRouteEnable10.Location = new System.Drawing.Point(222, 60);
            this.checkBoxRouteEnable10.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxRouteEnable10.Name = "checkBoxRouteEnable10";
            this.checkBoxRouteEnable10.Size = new System.Drawing.Size(57, 20);
            this.checkBoxRouteEnable10.TabIndex = 256;
            this.checkBoxRouteEnable10.Text = "Ch10";
            this.checkBoxRouteEnable10.UseVisualStyleBackColor = true;
            // 
            // checkBoxRouteEnable2
            // 
            this.checkBoxRouteEnable2.AutoSize = true;
            this.checkBoxRouteEnable2.Checked = true;
            this.checkBoxRouteEnable2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRouteEnable2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRouteEnable2.Location = new System.Drawing.Point(222, 12);
            this.checkBoxRouteEnable2.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxRouteEnable2.Name = "checkBoxRouteEnable2";
            this.checkBoxRouteEnable2.Size = new System.Drawing.Size(50, 20);
            this.checkBoxRouteEnable2.TabIndex = 248;
            this.checkBoxRouteEnable2.Text = "Ch2";
            this.checkBoxRouteEnable2.UseVisualStyleBackColor = true;
            // 
            // checkBoxRouteEnable9
            // 
            this.checkBoxRouteEnable9.AutoSize = true;
            this.checkBoxRouteEnable9.Checked = true;
            this.checkBoxRouteEnable9.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRouteEnable9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRouteEnable9.Location = new System.Drawing.Point(152, 60);
            this.checkBoxRouteEnable9.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxRouteEnable9.Name = "checkBoxRouteEnable9";
            this.checkBoxRouteEnable9.Size = new System.Drawing.Size(50, 20);
            this.checkBoxRouteEnable9.TabIndex = 255;
            this.checkBoxRouteEnable9.Text = "Ch9";
            this.checkBoxRouteEnable9.UseVisualStyleBackColor = true;
            // 
            // checkBoxRouteEnable3
            // 
            this.checkBoxRouteEnable3.AutoSize = true;
            this.checkBoxRouteEnable3.Checked = true;
            this.checkBoxRouteEnable3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRouteEnable3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRouteEnable3.Location = new System.Drawing.Point(290, 12);
            this.checkBoxRouteEnable3.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxRouteEnable3.Name = "checkBoxRouteEnable3";
            this.checkBoxRouteEnable3.Size = new System.Drawing.Size(50, 20);
            this.checkBoxRouteEnable3.TabIndex = 249;
            this.checkBoxRouteEnable3.Text = "Ch3";
            this.checkBoxRouteEnable3.UseVisualStyleBackColor = true;
            // 
            // checkBoxRouteEnable8
            // 
            this.checkBoxRouteEnable8.AutoSize = true;
            this.checkBoxRouteEnable8.Checked = true;
            this.checkBoxRouteEnable8.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRouteEnable8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRouteEnable8.Location = new System.Drawing.Point(78, 60);
            this.checkBoxRouteEnable8.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxRouteEnable8.Name = "checkBoxRouteEnable8";
            this.checkBoxRouteEnable8.Size = new System.Drawing.Size(50, 20);
            this.checkBoxRouteEnable8.TabIndex = 254;
            this.checkBoxRouteEnable8.Text = "Ch8";
            this.checkBoxRouteEnable8.UseVisualStyleBackColor = true;
            // 
            // checkBoxRouteEnable4
            // 
            this.checkBoxRouteEnable4.AutoSize = true;
            this.checkBoxRouteEnable4.Checked = true;
            this.checkBoxRouteEnable4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRouteEnable4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRouteEnable4.Location = new System.Drawing.Point(78, 36);
            this.checkBoxRouteEnable4.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxRouteEnable4.Name = "checkBoxRouteEnable4";
            this.checkBoxRouteEnable4.Size = new System.Drawing.Size(50, 20);
            this.checkBoxRouteEnable4.TabIndex = 250;
            this.checkBoxRouteEnable4.Text = "Ch4";
            this.checkBoxRouteEnable4.UseVisualStyleBackColor = true;
            // 
            // checkBoxRouteEnable7
            // 
            this.checkBoxRouteEnable7.AutoSize = true;
            this.checkBoxRouteEnable7.Checked = true;
            this.checkBoxRouteEnable7.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRouteEnable7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRouteEnable7.Location = new System.Drawing.Point(290, 36);
            this.checkBoxRouteEnable7.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxRouteEnable7.Name = "checkBoxRouteEnable7";
            this.checkBoxRouteEnable7.Size = new System.Drawing.Size(50, 20);
            this.checkBoxRouteEnable7.TabIndex = 253;
            this.checkBoxRouteEnable7.Text = "Ch7";
            this.checkBoxRouteEnable7.UseVisualStyleBackColor = true;
            // 
            // checkBoxRouteEnable5
            // 
            this.checkBoxRouteEnable5.AutoSize = true;
            this.checkBoxRouteEnable5.Checked = true;
            this.checkBoxRouteEnable5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRouteEnable5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRouteEnable5.Location = new System.Drawing.Point(152, 36);
            this.checkBoxRouteEnable5.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxRouteEnable5.Name = "checkBoxRouteEnable5";
            this.checkBoxRouteEnable5.Size = new System.Drawing.Size(50, 20);
            this.checkBoxRouteEnable5.TabIndex = 251;
            this.checkBoxRouteEnable5.Text = "Ch5";
            this.checkBoxRouteEnable5.UseVisualStyleBackColor = true;
            // 
            // checkBoxRouteEnable6
            // 
            this.checkBoxRouteEnable6.AutoSize = true;
            this.checkBoxRouteEnable6.Checked = true;
            this.checkBoxRouteEnable6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRouteEnable6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRouteEnable6.Location = new System.Drawing.Point(222, 36);
            this.checkBoxRouteEnable6.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxRouteEnable6.Name = "checkBoxRouteEnable6";
            this.checkBoxRouteEnable6.Size = new System.Drawing.Size(50, 20);
            this.checkBoxRouteEnable6.TabIndex = 252;
            this.checkBoxRouteEnable6.Text = "Ch6";
            this.checkBoxRouteEnable6.UseVisualStyleBackColor = true;
            // 
            // tabPageRecyclerContent
            // 
            this.tabPageRecyclerContent.BackColor = System.Drawing.Color.Tan;
            this.tabPageRecyclerContent.Controls.Add(this.label82);
            this.tabPageRecyclerContent.Controls.Add(this.labelRtnGetMDBRecyclerContent);
            this.tabPageRecyclerContent.Controls.Add(this.buttonGetMDBRecyclerContent);
            this.tabPageRecyclerContent.Controls.Add(this.label85);
            this.tabPageRecyclerContent.Controls.Add(this.label86);
            this.tabPageRecyclerContent.Controls.Add(this.label87);
            this.tabPageRecyclerContent.Controls.Add(this.label88);
            this.tabPageRecyclerContent.Controls.Add(this.labelRecyclerContent15);
            this.tabPageRecyclerContent.Controls.Add(this.labelRecyclerContent14);
            this.tabPageRecyclerContent.Controls.Add(this.labelRecyclerContent13);
            this.tabPageRecyclerContent.Controls.Add(this.labelRecyclerContent12);
            this.tabPageRecyclerContent.Controls.Add(this.labelRecyclerContent11);
            this.tabPageRecyclerContent.Controls.Add(this.labelRecyclerContent10);
            this.tabPageRecyclerContent.Controls.Add(this.labelRecyclerContent9);
            this.tabPageRecyclerContent.Controls.Add(this.labelRecyclerContent8);
            this.tabPageRecyclerContent.Controls.Add(this.labelRecyclerContent7);
            this.tabPageRecyclerContent.Controls.Add(this.labelRecyclerContent6);
            this.tabPageRecyclerContent.Controls.Add(this.labelRecyclerContent5);
            this.tabPageRecyclerContent.Controls.Add(this.labelRecyclerContent4);
            this.tabPageRecyclerContent.Controls.Add(this.labelRecyclerContent3);
            this.tabPageRecyclerContent.Controls.Add(this.labelRecyclerContent2);
            this.tabPageRecyclerContent.Controls.Add(this.labelRecyclerContent1);
            this.tabPageRecyclerContent.Controls.Add(this.labelRecyclerContent0);
            this.tabPageRecyclerContent.Location = new System.Drawing.Point(4, 22);
            this.tabPageRecyclerContent.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageRecyclerContent.Name = "tabPageRecyclerContent";
            this.tabPageRecyclerContent.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageRecyclerContent.Size = new System.Drawing.Size(432, 154);
            this.tabPageRecyclerContent.TabIndex = 3;
            this.tabPageRecyclerContent.Text = "Recycler Content";
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.Location = new System.Drawing.Point(183, 129);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(69, 13);
            this.label82.TabIndex = 266;
            this.label82.Text = "Return Value";
            // 
            // labelRtnGetMDBRecyclerContent
            // 
            this.labelRtnGetMDBRecyclerContent.AutoSize = true;
            this.labelRtnGetMDBRecyclerContent.BackColor = System.Drawing.Color.White;
            this.labelRtnGetMDBRecyclerContent.Location = new System.Drawing.Point(267, 129);
            this.labelRtnGetMDBRecyclerContent.Name = "labelRtnGetMDBRecyclerContent";
            this.labelRtnGetMDBRecyclerContent.Size = new System.Drawing.Size(13, 13);
            this.labelRtnGetMDBRecyclerContent.TabIndex = 265;
            this.labelRtnGetMDBRecyclerContent.Text = "0";
            // 
            // buttonGetMDBRecyclerContent
            // 
            this.buttonGetMDBRecyclerContent.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonGetMDBRecyclerContent.Location = new System.Drawing.Point(43, 123);
            this.buttonGetMDBRecyclerContent.Name = "buttonGetMDBRecyclerContent";
            this.buttonGetMDBRecyclerContent.Size = new System.Drawing.Size(118, 24);
            this.buttonGetMDBRecyclerContent.TabIndex = 264;
            this.buttonGetMDBRecyclerContent.Text = "Get Recycler Content";
            this.buttonGetMDBRecyclerContent.UseVisualStyleBackColor = false;
            this.buttonGetMDBRecyclerContent.Click += new System.EventHandler(this.buttonGetMDBRecyclerContent_Click);
            // 
            // label85
            // 
            this.label85.AutoSize = true;
            this.label85.BackColor = System.Drawing.Color.Tan;
            this.label85.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label85.Location = new System.Drawing.Point(18, 92);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(111, 17);
            this.label85.TabIndex = 263;
            this.label85.Text = "Ch12 to Ch15 ->";
            this.label85.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label86
            // 
            this.label86.AutoSize = true;
            this.label86.BackColor = System.Drawing.Color.Tan;
            this.label86.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label86.Location = new System.Drawing.Point(26, 66);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(103, 17);
            this.label86.TabIndex = 262;
            this.label86.Text = "Ch8 to Ch11 ->";
            this.label86.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label87
            // 
            this.label87.AutoSize = true;
            this.label87.BackColor = System.Drawing.Color.Tan;
            this.label87.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label87.Location = new System.Drawing.Point(34, 40);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(95, 17);
            this.label87.TabIndex = 261;
            this.label87.Text = "Ch4 to Ch7 ->";
            this.label87.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label88
            // 
            this.label88.AutoSize = true;
            this.label88.BackColor = System.Drawing.Color.Tan;
            this.label88.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label88.Location = new System.Drawing.Point(34, 14);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(95, 17);
            this.label88.TabIndex = 260;
            this.label88.Text = "Ch0 to Ch3 ->";
            this.label88.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRecyclerContent15
            // 
            this.labelRecyclerContent15.AutoSize = true;
            this.labelRecyclerContent15.BackColor = System.Drawing.Color.Gray;
            this.labelRecyclerContent15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelRecyclerContent15.Location = new System.Drawing.Point(364, 92);
            this.labelRecyclerContent15.Name = "labelRecyclerContent15";
            this.labelRecyclerContent15.Size = new System.Drawing.Size(16, 17);
            this.labelRecyclerContent15.TabIndex = 259;
            this.labelRecyclerContent15.Text = "0";
            this.labelRecyclerContent15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRecyclerContent14
            // 
            this.labelRecyclerContent14.AutoSize = true;
            this.labelRecyclerContent14.BackColor = System.Drawing.Color.Gray;
            this.labelRecyclerContent14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelRecyclerContent14.Location = new System.Drawing.Point(288, 92);
            this.labelRecyclerContent14.Name = "labelRecyclerContent14";
            this.labelRecyclerContent14.Size = new System.Drawing.Size(16, 17);
            this.labelRecyclerContent14.TabIndex = 258;
            this.labelRecyclerContent14.Text = "0";
            this.labelRecyclerContent14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRecyclerContent13
            // 
            this.labelRecyclerContent13.AutoSize = true;
            this.labelRecyclerContent13.BackColor = System.Drawing.Color.Gray;
            this.labelRecyclerContent13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelRecyclerContent13.Location = new System.Drawing.Point(216, 92);
            this.labelRecyclerContent13.Name = "labelRecyclerContent13";
            this.labelRecyclerContent13.Size = new System.Drawing.Size(16, 17);
            this.labelRecyclerContent13.TabIndex = 257;
            this.labelRecyclerContent13.Text = "0";
            this.labelRecyclerContent13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRecyclerContent12
            // 
            this.labelRecyclerContent12.AutoSize = true;
            this.labelRecyclerContent12.BackColor = System.Drawing.Color.Gray;
            this.labelRecyclerContent12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelRecyclerContent12.Location = new System.Drawing.Point(142, 92);
            this.labelRecyclerContent12.Name = "labelRecyclerContent12";
            this.labelRecyclerContent12.Size = new System.Drawing.Size(16, 17);
            this.labelRecyclerContent12.TabIndex = 256;
            this.labelRecyclerContent12.Text = "0";
            this.labelRecyclerContent12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRecyclerContent11
            // 
            this.labelRecyclerContent11.AutoSize = true;
            this.labelRecyclerContent11.BackColor = System.Drawing.Color.Gray;
            this.labelRecyclerContent11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelRecyclerContent11.Location = new System.Drawing.Point(364, 66);
            this.labelRecyclerContent11.Name = "labelRecyclerContent11";
            this.labelRecyclerContent11.Size = new System.Drawing.Size(16, 17);
            this.labelRecyclerContent11.TabIndex = 255;
            this.labelRecyclerContent11.Text = "0";
            this.labelRecyclerContent11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRecyclerContent10
            // 
            this.labelRecyclerContent10.AutoSize = true;
            this.labelRecyclerContent10.BackColor = System.Drawing.Color.Gray;
            this.labelRecyclerContent10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelRecyclerContent10.Location = new System.Drawing.Point(288, 66);
            this.labelRecyclerContent10.Name = "labelRecyclerContent10";
            this.labelRecyclerContent10.Size = new System.Drawing.Size(16, 17);
            this.labelRecyclerContent10.TabIndex = 254;
            this.labelRecyclerContent10.Text = "0";
            this.labelRecyclerContent10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRecyclerContent9
            // 
            this.labelRecyclerContent9.AutoSize = true;
            this.labelRecyclerContent9.BackColor = System.Drawing.Color.Gray;
            this.labelRecyclerContent9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelRecyclerContent9.Location = new System.Drawing.Point(216, 66);
            this.labelRecyclerContent9.Name = "labelRecyclerContent9";
            this.labelRecyclerContent9.Size = new System.Drawing.Size(16, 17);
            this.labelRecyclerContent9.TabIndex = 253;
            this.labelRecyclerContent9.Text = "0";
            this.labelRecyclerContent9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRecyclerContent8
            // 
            this.labelRecyclerContent8.AutoSize = true;
            this.labelRecyclerContent8.BackColor = System.Drawing.Color.Gray;
            this.labelRecyclerContent8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelRecyclerContent8.Location = new System.Drawing.Point(142, 66);
            this.labelRecyclerContent8.Name = "labelRecyclerContent8";
            this.labelRecyclerContent8.Size = new System.Drawing.Size(16, 17);
            this.labelRecyclerContent8.TabIndex = 252;
            this.labelRecyclerContent8.Text = "0";
            this.labelRecyclerContent8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRecyclerContent7
            // 
            this.labelRecyclerContent7.AutoSize = true;
            this.labelRecyclerContent7.BackColor = System.Drawing.Color.Gray;
            this.labelRecyclerContent7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelRecyclerContent7.Location = new System.Drawing.Point(364, 40);
            this.labelRecyclerContent7.Name = "labelRecyclerContent7";
            this.labelRecyclerContent7.Size = new System.Drawing.Size(16, 17);
            this.labelRecyclerContent7.TabIndex = 251;
            this.labelRecyclerContent7.Text = "0";
            this.labelRecyclerContent7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRecyclerContent6
            // 
            this.labelRecyclerContent6.AutoSize = true;
            this.labelRecyclerContent6.BackColor = System.Drawing.Color.Gray;
            this.labelRecyclerContent6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelRecyclerContent6.Location = new System.Drawing.Point(288, 40);
            this.labelRecyclerContent6.Name = "labelRecyclerContent6";
            this.labelRecyclerContent6.Size = new System.Drawing.Size(16, 17);
            this.labelRecyclerContent6.TabIndex = 250;
            this.labelRecyclerContent6.Text = "0";
            this.labelRecyclerContent6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRecyclerContent5
            // 
            this.labelRecyclerContent5.AutoSize = true;
            this.labelRecyclerContent5.BackColor = System.Drawing.Color.Gray;
            this.labelRecyclerContent5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelRecyclerContent5.Location = new System.Drawing.Point(216, 40);
            this.labelRecyclerContent5.Name = "labelRecyclerContent5";
            this.labelRecyclerContent5.Size = new System.Drawing.Size(16, 17);
            this.labelRecyclerContent5.TabIndex = 249;
            this.labelRecyclerContent5.Text = "0";
            this.labelRecyclerContent5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRecyclerContent4
            // 
            this.labelRecyclerContent4.AutoSize = true;
            this.labelRecyclerContent4.BackColor = System.Drawing.Color.Gray;
            this.labelRecyclerContent4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelRecyclerContent4.Location = new System.Drawing.Point(142, 40);
            this.labelRecyclerContent4.Name = "labelRecyclerContent4";
            this.labelRecyclerContent4.Size = new System.Drawing.Size(16, 17);
            this.labelRecyclerContent4.TabIndex = 248;
            this.labelRecyclerContent4.Text = "0";
            this.labelRecyclerContent4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRecyclerContent3
            // 
            this.labelRecyclerContent3.AutoSize = true;
            this.labelRecyclerContent3.BackColor = System.Drawing.Color.Gray;
            this.labelRecyclerContent3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelRecyclerContent3.Location = new System.Drawing.Point(364, 14);
            this.labelRecyclerContent3.Name = "labelRecyclerContent3";
            this.labelRecyclerContent3.Size = new System.Drawing.Size(16, 17);
            this.labelRecyclerContent3.TabIndex = 247;
            this.labelRecyclerContent3.Text = "0";
            this.labelRecyclerContent3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRecyclerContent2
            // 
            this.labelRecyclerContent2.AutoSize = true;
            this.labelRecyclerContent2.BackColor = System.Drawing.Color.Gray;
            this.labelRecyclerContent2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelRecyclerContent2.Location = new System.Drawing.Point(288, 14);
            this.labelRecyclerContent2.Name = "labelRecyclerContent2";
            this.labelRecyclerContent2.Size = new System.Drawing.Size(16, 17);
            this.labelRecyclerContent2.TabIndex = 246;
            this.labelRecyclerContent2.Text = "0";
            this.labelRecyclerContent2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRecyclerContent1
            // 
            this.labelRecyclerContent1.AutoSize = true;
            this.labelRecyclerContent1.BackColor = System.Drawing.Color.Gray;
            this.labelRecyclerContent1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelRecyclerContent1.Location = new System.Drawing.Point(216, 14);
            this.labelRecyclerContent1.Name = "labelRecyclerContent1";
            this.labelRecyclerContent1.Size = new System.Drawing.Size(16, 17);
            this.labelRecyclerContent1.TabIndex = 245;
            this.labelRecyclerContent1.Text = "0";
            this.labelRecyclerContent1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRecyclerContent0
            // 
            this.labelRecyclerContent0.AutoSize = true;
            this.labelRecyclerContent0.BackColor = System.Drawing.Color.Gray;
            this.labelRecyclerContent0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelRecyclerContent0.Location = new System.Drawing.Point(142, 14);
            this.labelRecyclerContent0.Name = "labelRecyclerContent0";
            this.labelRecyclerContent0.Size = new System.Drawing.Size(16, 17);
            this.labelRecyclerContent0.TabIndex = 244;
            this.labelRecyclerContent0.Text = "0";
            this.labelRecyclerContent0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabPageRecyclerPayoutFinal
            // 
            this.tabPageRecyclerPayoutFinal.BackColor = System.Drawing.Color.Tan;
            this.tabPageRecyclerPayoutFinal.Controls.Add(this.label77);
            this.tabPageRecyclerPayoutFinal.Controls.Add(this.labelGetMDBRecyclerPayoutFinalAckOnly);
            this.tabPageRecyclerPayoutFinal.Controls.Add(this.label80);
            this.tabPageRecyclerPayoutFinal.Controls.Add(this.label81);
            this.tabPageRecyclerPayoutFinal.Controls.Add(this.label84);
            this.tabPageRecyclerPayoutFinal.Controls.Add(this.label102);
            this.tabPageRecyclerPayoutFinal.Controls.Add(this.labelRecyclerPayoutFinal15);
            this.tabPageRecyclerPayoutFinal.Controls.Add(this.labelRecyclerPayoutFinal14);
            this.tabPageRecyclerPayoutFinal.Controls.Add(this.labelRecyclerPayoutFinal13);
            this.tabPageRecyclerPayoutFinal.Controls.Add(this.labelRecyclerPayoutFinal12);
            this.tabPageRecyclerPayoutFinal.Controls.Add(this.labelRecyclerPayoutFinal11);
            this.tabPageRecyclerPayoutFinal.Controls.Add(this.labelRecyclerPayoutFinal10);
            this.tabPageRecyclerPayoutFinal.Controls.Add(this.labelRecyclerPayoutFinal9);
            this.tabPageRecyclerPayoutFinal.Controls.Add(this.labelRecyclerPayoutFinal8);
            this.tabPageRecyclerPayoutFinal.Controls.Add(this.labelRecyclerPayoutFinal7);
            this.tabPageRecyclerPayoutFinal.Controls.Add(this.labelRecyclerPayoutFinal6);
            this.tabPageRecyclerPayoutFinal.Controls.Add(this.labelRecyclerPayoutFinal5);
            this.tabPageRecyclerPayoutFinal.Controls.Add(this.labelRecyclerPayoutFinal4);
            this.tabPageRecyclerPayoutFinal.Controls.Add(this.labelRecyclerPayoutFinal3);
            this.tabPageRecyclerPayoutFinal.Controls.Add(this.labelRecyclerPayoutFinal2);
            this.tabPageRecyclerPayoutFinal.Controls.Add(this.labelRecyclerPayoutFinal1);
            this.tabPageRecyclerPayoutFinal.Controls.Add(this.labelRecyclerPayoutFinal0);
            this.tabPageRecyclerPayoutFinal.Controls.Add(this.buttonGetMDBRecyclerPayoutFinal);
            this.tabPageRecyclerPayoutFinal.Controls.Add(this.labelRtnGetMDBRecyclerPayoutFinal);
            this.tabPageRecyclerPayoutFinal.Location = new System.Drawing.Point(4, 22);
            this.tabPageRecyclerPayoutFinal.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageRecyclerPayoutFinal.Name = "tabPageRecyclerPayoutFinal";
            this.tabPageRecyclerPayoutFinal.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageRecyclerPayoutFinal.Size = new System.Drawing.Size(432, 154);
            this.tabPageRecyclerPayoutFinal.TabIndex = 4;
            this.tabPageRecyclerPayoutFinal.Text = "Payout Final";
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Location = new System.Drawing.Point(181, 126);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(69, 13);
            this.label77.TabIndex = 270;
            this.label77.Text = "Return Value";
            // 
            // labelGetMDBRecyclerPayoutFinalAckOnly
            // 
            this.labelGetMDBRecyclerPayoutFinalAckOnly.AutoSize = true;
            this.labelGetMDBRecyclerPayoutFinalAckOnly.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelGetMDBRecyclerPayoutFinalAckOnly.Location = new System.Drawing.Point(317, 126);
            this.labelGetMDBRecyclerPayoutFinalAckOnly.Name = "labelGetMDBRecyclerPayoutFinalAckOnly";
            this.labelGetMDBRecyclerPayoutFinalAckOnly.Size = new System.Drawing.Size(26, 13);
            this.labelGetMDBRecyclerPayoutFinalAckOnly.TabIndex = 249;
            this.labelGetMDBRecyclerPayoutFinalAckOnly.Text = "Ack";
            this.labelGetMDBRecyclerPayoutFinalAckOnly.Visible = false;
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.BackColor = System.Drawing.Color.Tan;
            this.label80.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label80.Location = new System.Drawing.Point(18, 92);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(111, 17);
            this.label80.TabIndex = 269;
            this.label80.Text = "Ch12 to Ch15 ->";
            this.label80.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.BackColor = System.Drawing.Color.Tan;
            this.label81.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label81.Location = new System.Drawing.Point(26, 66);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(103, 17);
            this.label81.TabIndex = 268;
            this.label81.Text = "Ch8 to Ch11 ->";
            this.label81.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.BackColor = System.Drawing.Color.Tan;
            this.label84.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label84.Location = new System.Drawing.Point(34, 40);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(95, 17);
            this.label84.TabIndex = 267;
            this.label84.Text = "Ch4 to Ch7 ->";
            this.label84.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label102
            // 
            this.label102.AutoSize = true;
            this.label102.BackColor = System.Drawing.Color.Tan;
            this.label102.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label102.Location = new System.Drawing.Point(34, 14);
            this.label102.Name = "label102";
            this.label102.Size = new System.Drawing.Size(95, 17);
            this.label102.TabIndex = 266;
            this.label102.Text = "Ch0 to Ch3 ->";
            this.label102.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRecyclerPayoutFinal15
            // 
            this.labelRecyclerPayoutFinal15.AutoSize = true;
            this.labelRecyclerPayoutFinal15.BackColor = System.Drawing.Color.Gray;
            this.labelRecyclerPayoutFinal15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelRecyclerPayoutFinal15.Location = new System.Drawing.Point(364, 92);
            this.labelRecyclerPayoutFinal15.Name = "labelRecyclerPayoutFinal15";
            this.labelRecyclerPayoutFinal15.Size = new System.Drawing.Size(16, 17);
            this.labelRecyclerPayoutFinal15.TabIndex = 265;
            this.labelRecyclerPayoutFinal15.Text = "0";
            this.labelRecyclerPayoutFinal15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRecyclerPayoutFinal14
            // 
            this.labelRecyclerPayoutFinal14.AutoSize = true;
            this.labelRecyclerPayoutFinal14.BackColor = System.Drawing.Color.Gray;
            this.labelRecyclerPayoutFinal14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelRecyclerPayoutFinal14.Location = new System.Drawing.Point(288, 92);
            this.labelRecyclerPayoutFinal14.Name = "labelRecyclerPayoutFinal14";
            this.labelRecyclerPayoutFinal14.Size = new System.Drawing.Size(16, 17);
            this.labelRecyclerPayoutFinal14.TabIndex = 264;
            this.labelRecyclerPayoutFinal14.Text = "0";
            this.labelRecyclerPayoutFinal14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRecyclerPayoutFinal13
            // 
            this.labelRecyclerPayoutFinal13.AutoSize = true;
            this.labelRecyclerPayoutFinal13.BackColor = System.Drawing.Color.Gray;
            this.labelRecyclerPayoutFinal13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelRecyclerPayoutFinal13.Location = new System.Drawing.Point(216, 92);
            this.labelRecyclerPayoutFinal13.Name = "labelRecyclerPayoutFinal13";
            this.labelRecyclerPayoutFinal13.Size = new System.Drawing.Size(16, 17);
            this.labelRecyclerPayoutFinal13.TabIndex = 263;
            this.labelRecyclerPayoutFinal13.Text = "0";
            this.labelRecyclerPayoutFinal13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRecyclerPayoutFinal12
            // 
            this.labelRecyclerPayoutFinal12.AutoSize = true;
            this.labelRecyclerPayoutFinal12.BackColor = System.Drawing.Color.Gray;
            this.labelRecyclerPayoutFinal12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelRecyclerPayoutFinal12.Location = new System.Drawing.Point(142, 92);
            this.labelRecyclerPayoutFinal12.Name = "labelRecyclerPayoutFinal12";
            this.labelRecyclerPayoutFinal12.Size = new System.Drawing.Size(16, 17);
            this.labelRecyclerPayoutFinal12.TabIndex = 262;
            this.labelRecyclerPayoutFinal12.Text = "0";
            this.labelRecyclerPayoutFinal12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRecyclerPayoutFinal11
            // 
            this.labelRecyclerPayoutFinal11.AutoSize = true;
            this.labelRecyclerPayoutFinal11.BackColor = System.Drawing.Color.Gray;
            this.labelRecyclerPayoutFinal11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelRecyclerPayoutFinal11.Location = new System.Drawing.Point(364, 66);
            this.labelRecyclerPayoutFinal11.Name = "labelRecyclerPayoutFinal11";
            this.labelRecyclerPayoutFinal11.Size = new System.Drawing.Size(16, 17);
            this.labelRecyclerPayoutFinal11.TabIndex = 261;
            this.labelRecyclerPayoutFinal11.Text = "0";
            this.labelRecyclerPayoutFinal11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRecyclerPayoutFinal10
            // 
            this.labelRecyclerPayoutFinal10.AutoSize = true;
            this.labelRecyclerPayoutFinal10.BackColor = System.Drawing.Color.Gray;
            this.labelRecyclerPayoutFinal10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelRecyclerPayoutFinal10.Location = new System.Drawing.Point(288, 66);
            this.labelRecyclerPayoutFinal10.Name = "labelRecyclerPayoutFinal10";
            this.labelRecyclerPayoutFinal10.Size = new System.Drawing.Size(16, 17);
            this.labelRecyclerPayoutFinal10.TabIndex = 260;
            this.labelRecyclerPayoutFinal10.Text = "0";
            this.labelRecyclerPayoutFinal10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRecyclerPayoutFinal9
            // 
            this.labelRecyclerPayoutFinal9.AutoSize = true;
            this.labelRecyclerPayoutFinal9.BackColor = System.Drawing.Color.Gray;
            this.labelRecyclerPayoutFinal9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelRecyclerPayoutFinal9.Location = new System.Drawing.Point(216, 66);
            this.labelRecyclerPayoutFinal9.Name = "labelRecyclerPayoutFinal9";
            this.labelRecyclerPayoutFinal9.Size = new System.Drawing.Size(16, 17);
            this.labelRecyclerPayoutFinal9.TabIndex = 259;
            this.labelRecyclerPayoutFinal9.Text = "0";
            this.labelRecyclerPayoutFinal9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRecyclerPayoutFinal8
            // 
            this.labelRecyclerPayoutFinal8.AutoSize = true;
            this.labelRecyclerPayoutFinal8.BackColor = System.Drawing.Color.Gray;
            this.labelRecyclerPayoutFinal8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelRecyclerPayoutFinal8.Location = new System.Drawing.Point(142, 66);
            this.labelRecyclerPayoutFinal8.Name = "labelRecyclerPayoutFinal8";
            this.labelRecyclerPayoutFinal8.Size = new System.Drawing.Size(16, 17);
            this.labelRecyclerPayoutFinal8.TabIndex = 258;
            this.labelRecyclerPayoutFinal8.Text = "0";
            this.labelRecyclerPayoutFinal8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRecyclerPayoutFinal7
            // 
            this.labelRecyclerPayoutFinal7.AutoSize = true;
            this.labelRecyclerPayoutFinal7.BackColor = System.Drawing.Color.Gray;
            this.labelRecyclerPayoutFinal7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelRecyclerPayoutFinal7.Location = new System.Drawing.Point(364, 40);
            this.labelRecyclerPayoutFinal7.Name = "labelRecyclerPayoutFinal7";
            this.labelRecyclerPayoutFinal7.Size = new System.Drawing.Size(16, 17);
            this.labelRecyclerPayoutFinal7.TabIndex = 257;
            this.labelRecyclerPayoutFinal7.Text = "0";
            this.labelRecyclerPayoutFinal7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRecyclerPayoutFinal6
            // 
            this.labelRecyclerPayoutFinal6.AutoSize = true;
            this.labelRecyclerPayoutFinal6.BackColor = System.Drawing.Color.Gray;
            this.labelRecyclerPayoutFinal6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelRecyclerPayoutFinal6.Location = new System.Drawing.Point(288, 40);
            this.labelRecyclerPayoutFinal6.Name = "labelRecyclerPayoutFinal6";
            this.labelRecyclerPayoutFinal6.Size = new System.Drawing.Size(16, 17);
            this.labelRecyclerPayoutFinal6.TabIndex = 256;
            this.labelRecyclerPayoutFinal6.Text = "0";
            this.labelRecyclerPayoutFinal6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRecyclerPayoutFinal5
            // 
            this.labelRecyclerPayoutFinal5.AutoSize = true;
            this.labelRecyclerPayoutFinal5.BackColor = System.Drawing.Color.Gray;
            this.labelRecyclerPayoutFinal5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelRecyclerPayoutFinal5.Location = new System.Drawing.Point(216, 40);
            this.labelRecyclerPayoutFinal5.Name = "labelRecyclerPayoutFinal5";
            this.labelRecyclerPayoutFinal5.Size = new System.Drawing.Size(16, 17);
            this.labelRecyclerPayoutFinal5.TabIndex = 255;
            this.labelRecyclerPayoutFinal5.Text = "0";
            this.labelRecyclerPayoutFinal5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRecyclerPayoutFinal4
            // 
            this.labelRecyclerPayoutFinal4.AutoSize = true;
            this.labelRecyclerPayoutFinal4.BackColor = System.Drawing.Color.Gray;
            this.labelRecyclerPayoutFinal4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelRecyclerPayoutFinal4.Location = new System.Drawing.Point(142, 40);
            this.labelRecyclerPayoutFinal4.Name = "labelRecyclerPayoutFinal4";
            this.labelRecyclerPayoutFinal4.Size = new System.Drawing.Size(16, 17);
            this.labelRecyclerPayoutFinal4.TabIndex = 254;
            this.labelRecyclerPayoutFinal4.Text = "0";
            this.labelRecyclerPayoutFinal4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRecyclerPayoutFinal3
            // 
            this.labelRecyclerPayoutFinal3.AutoSize = true;
            this.labelRecyclerPayoutFinal3.BackColor = System.Drawing.Color.Gray;
            this.labelRecyclerPayoutFinal3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelRecyclerPayoutFinal3.Location = new System.Drawing.Point(364, 14);
            this.labelRecyclerPayoutFinal3.Name = "labelRecyclerPayoutFinal3";
            this.labelRecyclerPayoutFinal3.Size = new System.Drawing.Size(16, 17);
            this.labelRecyclerPayoutFinal3.TabIndex = 253;
            this.labelRecyclerPayoutFinal3.Text = "0";
            this.labelRecyclerPayoutFinal3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRecyclerPayoutFinal2
            // 
            this.labelRecyclerPayoutFinal2.AutoSize = true;
            this.labelRecyclerPayoutFinal2.BackColor = System.Drawing.Color.Gray;
            this.labelRecyclerPayoutFinal2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelRecyclerPayoutFinal2.Location = new System.Drawing.Point(288, 14);
            this.labelRecyclerPayoutFinal2.Name = "labelRecyclerPayoutFinal2";
            this.labelRecyclerPayoutFinal2.Size = new System.Drawing.Size(16, 17);
            this.labelRecyclerPayoutFinal2.TabIndex = 252;
            this.labelRecyclerPayoutFinal2.Text = "0";
            this.labelRecyclerPayoutFinal2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRecyclerPayoutFinal1
            // 
            this.labelRecyclerPayoutFinal1.AutoSize = true;
            this.labelRecyclerPayoutFinal1.BackColor = System.Drawing.Color.Gray;
            this.labelRecyclerPayoutFinal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelRecyclerPayoutFinal1.Location = new System.Drawing.Point(216, 14);
            this.labelRecyclerPayoutFinal1.Name = "labelRecyclerPayoutFinal1";
            this.labelRecyclerPayoutFinal1.Size = new System.Drawing.Size(16, 17);
            this.labelRecyclerPayoutFinal1.TabIndex = 251;
            this.labelRecyclerPayoutFinal1.Text = "0";
            this.labelRecyclerPayoutFinal1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRecyclerPayoutFinal0
            // 
            this.labelRecyclerPayoutFinal0.AutoSize = true;
            this.labelRecyclerPayoutFinal0.BackColor = System.Drawing.Color.Gray;
            this.labelRecyclerPayoutFinal0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelRecyclerPayoutFinal0.Location = new System.Drawing.Point(142, 14);
            this.labelRecyclerPayoutFinal0.Name = "labelRecyclerPayoutFinal0";
            this.labelRecyclerPayoutFinal0.Size = new System.Drawing.Size(16, 17);
            this.labelRecyclerPayoutFinal0.TabIndex = 250;
            this.labelRecyclerPayoutFinal0.Text = "0";
            this.labelRecyclerPayoutFinal0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonGetMDBRecyclerPayoutFinal
            // 
            this.buttonGetMDBRecyclerPayoutFinal.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonGetMDBRecyclerPayoutFinal.Location = new System.Drawing.Point(43, 120);
            this.buttonGetMDBRecyclerPayoutFinal.Name = "buttonGetMDBRecyclerPayoutFinal";
            this.buttonGetMDBRecyclerPayoutFinal.Size = new System.Drawing.Size(120, 24);
            this.buttonGetMDBRecyclerPayoutFinal.TabIndex = 248;
            this.buttonGetMDBRecyclerPayoutFinal.Text = "Final Bill Payout";
            this.buttonGetMDBRecyclerPayoutFinal.UseVisualStyleBackColor = false;
            this.buttonGetMDBRecyclerPayoutFinal.Click += new System.EventHandler(this.buttonGetMDBRecyclerPayoutFinal_Click);
            // 
            // labelRtnGetMDBRecyclerPayoutFinal
            // 
            this.labelRtnGetMDBRecyclerPayoutFinal.AutoSize = true;
            this.labelRtnGetMDBRecyclerPayoutFinal.BackColor = System.Drawing.Color.White;
            this.labelRtnGetMDBRecyclerPayoutFinal.Location = new System.Drawing.Point(265, 126);
            this.labelRtnGetMDBRecyclerPayoutFinal.Name = "labelRtnGetMDBRecyclerPayoutFinal";
            this.labelRtnGetMDBRecyclerPayoutFinal.Size = new System.Drawing.Size(13, 13);
            this.labelRtnGetMDBRecyclerPayoutFinal.TabIndex = 247;
            this.labelRtnGetMDBRecyclerPayoutFinal.Text = "0";
            // 
            // labelBillStatusLightBox_ManualFilled
            // 
            this.labelBillStatusLightBox_ManualFilled.AutoSize = true;
            this.labelBillStatusLightBox_ManualFilled.BackColor = System.Drawing.Color.Gray;
            this.labelBillStatusLightBox_ManualFilled.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBillStatusLightBox_ManualFilled.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBillStatusLightBox_ManualFilled.Location = new System.Drawing.Point(852, 362);
            this.labelBillStatusLightBox_ManualFilled.Name = "labelBillStatusLightBox_ManualFilled";
            this.labelBillStatusLightBox_ManualFilled.Size = new System.Drawing.Size(90, 18);
            this.labelBillStatusLightBox_ManualFilled.TabIndex = 333;
            this.labelBillStatusLightBox_ManualFilled.Text = "Manual Filled";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(944, 362);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(15, 16);
            this.label28.TabIndex = 335;
            this.label28.Text = "$";
            // 
            // labelBillStatusLightBox_ManualFilledAmount
            // 
            this.labelBillStatusLightBox_ManualFilledAmount.AutoSize = true;
            this.labelBillStatusLightBox_ManualFilledAmount.BackColor = System.Drawing.Color.Gray;
            this.labelBillStatusLightBox_ManualFilledAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBillStatusLightBox_ManualFilledAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBillStatusLightBox_ManualFilledAmount.Location = new System.Drawing.Point(958, 362);
            this.labelBillStatusLightBox_ManualFilledAmount.Name = "labelBillStatusLightBox_ManualFilledAmount";
            this.labelBillStatusLightBox_ManualFilledAmount.Size = new System.Drawing.Size(17, 18);
            this.labelBillStatusLightBox_ManualFilledAmount.TabIndex = 334;
            this.labelBillStatusLightBox_ManualFilledAmount.Text = "0";
            // 
            // label101
            // 
            this.label101.AutoSize = true;
            this.label101.BackColor = System.Drawing.SystemColors.Control;
            this.label101.Location = new System.Drawing.Point(627, 414);
            this.label101.Name = "label101";
            this.label101.Size = new System.Drawing.Size(0, 13);
            this.label101.TabIndex = 336;
            // 
            // labelBillStatusLightBox_FillButton
            // 
            this.labelBillStatusLightBox_FillButton.AutoSize = true;
            this.labelBillStatusLightBox_FillButton.BackColor = System.Drawing.Color.Gray;
            this.labelBillStatusLightBox_FillButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBillStatusLightBox_FillButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBillStatusLightBox_FillButton.Location = new System.Drawing.Point(581, 386);
            this.labelBillStatusLightBox_FillButton.Name = "labelBillStatusLightBox_FillButton";
            this.labelBillStatusLightBox_FillButton.Size = new System.Drawing.Size(121, 18);
            this.labelBillStatusLightBox_FillButton.TabIndex = 337;
            this.labelBillStatusLightBox_FillButton.Text = "Fill Button Pressed";
            // 
            // labelBillStatusLightBox_EscrowButton
            // 
            this.labelBillStatusLightBox_EscrowButton.AutoSize = true;
            this.labelBillStatusLightBox_EscrowButton.BackColor = System.Drawing.Color.Gray;
            this.labelBillStatusLightBox_EscrowButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBillStatusLightBox_EscrowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBillStatusLightBox_EscrowButton.Location = new System.Drawing.Point(514, 411);
            this.labelBillStatusLightBox_EscrowButton.Name = "labelBillStatusLightBox_EscrowButton";
            this.labelBillStatusLightBox_EscrowButton.Size = new System.Drawing.Size(148, 18);
            this.labelBillStatusLightBox_EscrowButton.TabIndex = 338;
            this.labelBillStatusLightBox_EscrowButton.Text = "Escrow Button Pressed";
            // 
            // labelBillStatusLightBox_RecyclerDisabled
            // 
            this.labelBillStatusLightBox_RecyclerDisabled.AutoSize = true;
            this.labelBillStatusLightBox_RecyclerDisabled.BackColor = System.Drawing.Color.Gray;
            this.labelBillStatusLightBox_RecyclerDisabled.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBillStatusLightBox_RecyclerDisabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBillStatusLightBox_RecyclerDisabled.Location = new System.Drawing.Point(650, 362);
            this.labelBillStatusLightBox_RecyclerDisabled.Name = "labelBillStatusLightBox_RecyclerDisabled";
            this.labelBillStatusLightBox_RecyclerDisabled.Size = new System.Drawing.Size(122, 18);
            this.labelBillStatusLightBox_RecyclerDisabled.TabIndex = 339;
            this.labelBillStatusLightBox_RecyclerDisabled.Text = "Recycler Disabled";
            // 
            // labelCoinStatusLightBox_EscrowLever
            // 
            this.labelCoinStatusLightBox_EscrowLever.AutoSize = true;
            this.labelCoinStatusLightBox_EscrowLever.BackColor = System.Drawing.Color.Gray;
            this.labelCoinStatusLightBox_EscrowLever.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCoinStatusLightBox_EscrowLever.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCoinStatusLightBox_EscrowLever.Location = new System.Drawing.Point(20, 370);
            this.labelCoinStatusLightBox_EscrowLever.Name = "labelCoinStatusLightBox_EscrowLever";
            this.labelCoinStatusLightBox_EscrowLever.Size = new System.Drawing.Size(145, 18);
            this.labelCoinStatusLightBox_EscrowLever.TabIndex = 340;
            this.labelCoinStatusLightBox_EscrowLever.Text = "Escrow Lever Pressed";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(768, 693);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(69, 13);
            this.label51.TabIndex = 357;
            this.label51.Text = "Replied Data";
            // 
            // label110
            // 
            this.label110.AutoSize = true;
            this.label110.Location = new System.Drawing.Point(640, 693);
            this.label110.Name = "label110";
            this.label110.Size = new System.Drawing.Size(69, 13);
            this.label110.TabIndex = 356;
            this.label110.Text = "Return Value";
            // 
            // label111
            // 
            this.label111.AutoSize = true;
            this.label111.BackColor = System.Drawing.SystemColors.Control;
            this.label111.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label111.Location = new System.Drawing.Point(640, 658);
            this.label111.Name = "label111";
            this.label111.Size = new System.Drawing.Size(68, 17);
            this.label111.TabIndex = 355;
            this.label111.Text = "Amount $";
            this.label111.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDownDispenseMDBBillsByType2
            // 
            this.numericUpDownDispenseMDBBillsByType2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownDispenseMDBBillsByType2.Location = new System.Drawing.Point(778, 623);
            this.numericUpDownDispenseMDBBillsByType2.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDownDispenseMDBBillsByType2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDispenseMDBBillsByType2.Name = "numericUpDownDispenseMDBBillsByType2";
            this.numericUpDownDispenseMDBBillsByType2.Size = new System.Drawing.Size(59, 22);
            this.numericUpDownDispenseMDBBillsByType2.TabIndex = 353;
            this.numericUpDownDispenseMDBBillsByType2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownDispenseMDBBillsByType1
            // 
            this.numericUpDownDispenseMDBBillsByType1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownDispenseMDBBillsByType1.Location = new System.Drawing.Point(666, 623);
            this.numericUpDownDispenseMDBBillsByType1.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDownDispenseMDBBillsByType1.Name = "numericUpDownDispenseMDBBillsByType1";
            this.numericUpDownDispenseMDBBillsByType1.Size = new System.Drawing.Size(44, 22);
            this.numericUpDownDispenseMDBBillsByType1.TabIndex = 352;
            // 
            // labelPollMDBBillPayoutString
            // 
            this.labelPollMDBBillPayoutString.AutoSize = true;
            this.labelPollMDBBillPayoutString.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelPollMDBBillPayoutString.Location = new System.Drawing.Point(863, 693);
            this.labelPollMDBBillPayoutString.Name = "labelPollMDBBillPayoutString";
            this.labelPollMDBBillPayoutString.Size = new System.Drawing.Size(13, 13);
            this.labelPollMDBBillPayoutString.TabIndex = 351;
            this.labelPollMDBBillPayoutString.Text = "0";
            // 
            // label113
            // 
            this.label113.AutoSize = true;
            this.label113.Location = new System.Drawing.Point(844, 659);
            this.label113.Name = "label113";
            this.label113.Size = new System.Drawing.Size(69, 13);
            this.label113.TabIndex = 350;
            this.label113.Text = "Return Value";
            // 
            // label114
            // 
            this.label114.AutoSize = true;
            this.label114.Location = new System.Drawing.Point(844, 628);
            this.label114.Name = "label114";
            this.label114.Size = new System.Drawing.Size(69, 13);
            this.label114.TabIndex = 349;
            this.label114.Text = "Return Value";
            // 
            // label115
            // 
            this.label115.AutoSize = true;
            this.label115.BackColor = System.Drawing.SystemColors.Control;
            this.label115.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label115.Location = new System.Drawing.Point(716, 626);
            this.label115.Name = "label115";
            this.label115.Size = new System.Drawing.Size(60, 17);
            this.label115.TabIndex = 348;
            this.label115.Text = "# of bills";
            this.label115.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label116
            // 
            this.label116.AutoSize = true;
            this.label116.BackColor = System.Drawing.SystemColors.Control;
            this.label116.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label116.Location = new System.Drawing.Point(640, 626);
            this.label116.Name = "label116";
            this.label116.Size = new System.Drawing.Size(25, 17);
            this.label116.TabIndex = 347;
            this.label116.Text = "Ch";
            this.label116.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonDispenseMDBBillsByType
            // 
            this.buttonDispenseMDBBillsByType.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonDispenseMDBBillsByType.Location = new System.Drawing.Point(510, 623);
            this.buttonDispenseMDBBillsByType.Name = "buttonDispenseMDBBillsByType";
            this.buttonDispenseMDBBillsByType.Size = new System.Drawing.Size(118, 24);
            this.buttonDispenseMDBBillsByType.TabIndex = 346;
            this.buttonDispenseMDBBillsByType.Text = "Dispense Bill Type";
            this.buttonDispenseMDBBillsByType.UseVisualStyleBackColor = false;
            this.buttonDispenseMDBBillsByType.Click += new System.EventHandler(this.buttonDispenseMDBBillsByType_Click);
            // 
            // labelRtnDispenseMDBBillsByType
            // 
            this.labelRtnDispenseMDBBillsByType.AutoSize = true;
            this.labelRtnDispenseMDBBillsByType.BackColor = System.Drawing.Color.White;
            this.labelRtnDispenseMDBBillsByType.Location = new System.Drawing.Point(918, 628);
            this.labelRtnDispenseMDBBillsByType.Name = "labelRtnDispenseMDBBillsByType";
            this.labelRtnDispenseMDBBillsByType.Size = new System.Drawing.Size(13, 13);
            this.labelRtnDispenseMDBBillsByType.TabIndex = 345;
            this.labelRtnDispenseMDBBillsByType.Text = "0";
            // 
            // buttonDispenseMDBBillsByValue
            // 
            this.buttonDispenseMDBBillsByValue.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonDispenseMDBBillsByValue.Location = new System.Drawing.Point(510, 656);
            this.buttonDispenseMDBBillsByValue.Name = "buttonDispenseMDBBillsByValue";
            this.buttonDispenseMDBBillsByValue.Size = new System.Drawing.Size(118, 23);
            this.buttonDispenseMDBBillsByValue.TabIndex = 344;
            this.buttonDispenseMDBBillsByValue.Text = "Dispense Bill Value";
            this.buttonDispenseMDBBillsByValue.UseVisualStyleBackColor = false;
            this.buttonDispenseMDBBillsByValue.Click += new System.EventHandler(this.buttonDispenseMDBBillsByValue_Click);
            // 
            // labelRtnPollMDBBillPayout
            // 
            this.labelRtnPollMDBBillPayout.AutoSize = true;
            this.labelRtnPollMDBBillPayout.BackColor = System.Drawing.Color.White;
            this.labelRtnPollMDBBillPayout.Location = new System.Drawing.Point(719, 693);
            this.labelRtnPollMDBBillPayout.Name = "labelRtnPollMDBBillPayout";
            this.labelRtnPollMDBBillPayout.Size = new System.Drawing.Size(13, 13);
            this.labelRtnPollMDBBillPayout.TabIndex = 342;
            this.labelRtnPollMDBBillPayout.Text = "0";
            // 
            // buttonPollMDBBillPayout
            // 
            this.buttonPollMDBBillPayout.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonPollMDBBillPayout.Location = new System.Drawing.Point(510, 687);
            this.buttonPollMDBBillPayout.Name = "buttonPollMDBBillPayout";
            this.buttonPollMDBBillPayout.Size = new System.Drawing.Size(118, 24);
            this.buttonPollMDBBillPayout.TabIndex = 343;
            this.buttonPollMDBBillPayout.Text = "Poll Bill Payout";
            this.buttonPollMDBBillPayout.UseVisualStyleBackColor = false;
            this.buttonPollMDBBillPayout.Click += new System.EventHandler(this.buttonPollMDBBillPayout_Click);
            // 
            // labelRtnDispenseMDBBillsByValue
            // 
            this.labelRtnDispenseMDBBillsByValue.AutoSize = true;
            this.labelRtnDispenseMDBBillsByValue.BackColor = System.Drawing.Color.White;
            this.labelRtnDispenseMDBBillsByValue.Location = new System.Drawing.Point(918, 659);
            this.labelRtnDispenseMDBBillsByValue.Name = "labelRtnDispenseMDBBillsByValue";
            this.labelRtnDispenseMDBBillsByValue.Size = new System.Drawing.Size(13, 13);
            this.labelRtnDispenseMDBBillsByValue.TabIndex = 341;
            this.labelRtnDispenseMDBBillsByValue.Text = "0";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(640, 724);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(69, 13);
            this.label32.TabIndex = 360;
            this.label32.Text = "Return Value";
            // 
            // labelRtnCancelMDBBillPayout
            // 
            this.labelRtnCancelMDBBillPayout.AutoSize = true;
            this.labelRtnCancelMDBBillPayout.BackColor = System.Drawing.Color.White;
            this.labelRtnCancelMDBBillPayout.Location = new System.Drawing.Point(719, 724);
            this.labelRtnCancelMDBBillPayout.Name = "labelRtnCancelMDBBillPayout";
            this.labelRtnCancelMDBBillPayout.Size = new System.Drawing.Size(13, 13);
            this.labelRtnCancelMDBBillPayout.TabIndex = 358;
            this.labelRtnCancelMDBBillPayout.Text = "0";
            // 
            // buttonCancelMDBBillPayout
            // 
            this.buttonCancelMDBBillPayout.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonCancelMDBBillPayout.Location = new System.Drawing.Point(510, 719);
            this.buttonCancelMDBBillPayout.Name = "buttonCancelMDBBillPayout";
            this.buttonCancelMDBBillPayout.Size = new System.Drawing.Size(118, 24);
            this.buttonCancelMDBBillPayout.TabIndex = 359;
            this.buttonCancelMDBBillPayout.Text = "Cancel Bill Payout";
            this.buttonCancelMDBBillPayout.UseVisualStyleBackColor = false;
            this.buttonCancelMDBBillPayout.Click += new System.EventHandler(this.buttonCancelMDBBillPayout_Click);
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.BackColor = System.Drawing.SystemColors.Control;
            this.label79.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.17801F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label79.Location = new System.Drawing.Point(166, 121);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(106, 17);
            this.label79.TabIndex = 361;
            this.label79.Text = "Coin Changer";
            this.label79.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label103
            // 
            this.label103.AutoSize = true;
            this.label103.BackColor = System.Drawing.SystemColors.Control;
            this.label103.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.17801F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label103.Location = new System.Drawing.Point(650, 121);
            this.label103.Name = "label103";
            this.label103.Size = new System.Drawing.Size(177, 17);
            this.label103.TabIndex = 362;
            this.label103.Text = "Bill Acceptor / Recycler";
            this.label103.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.Location = new System.Drawing.Point(844, 690);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(15, 16);
            this.label46.TabIndex = 363;
            this.label46.Text = "$";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.Location = new System.Drawing.Point(340, 671);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(15, 16);
            this.label47.TabIndex = 364;
            this.label47.Text = "$";
            // 
            // labelMDBBillCondition
            // 
            this.labelMDBBillCondition.AutoSize = true;
            this.labelMDBBillCondition.BackColor = System.Drawing.Color.LightGreen;
            this.labelMDBBillCondition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMDBBillCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMDBBillCondition.Location = new System.Drawing.Point(842, 120);
            this.labelMDBBillCondition.Name = "labelMDBBillCondition";
            this.labelMDBBillCondition.Size = new System.Drawing.Size(55, 18);
            this.labelMDBBillCondition.TabIndex = 365;
            this.labelMDBBillCondition.Text = "Starting";
            // 
            // labelMDBCoinCondition
            // 
            this.labelMDBCoinCondition.AutoSize = true;
            this.labelMDBCoinCondition.BackColor = System.Drawing.Color.LightGreen;
            this.labelMDBCoinCondition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMDBCoinCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMDBCoinCondition.Location = new System.Drawing.Point(282, 120);
            this.labelMDBCoinCondition.Name = "labelMDBCoinCondition";
            this.labelMDBCoinCondition.Size = new System.Drawing.Size(55, 18);
            this.labelMDBCoinCondition.TabIndex = 366;
            this.labelMDBCoinCondition.Text = "Starting";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Location = new System.Drawing.Point(610, 4);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(390, 105);
            this.tabControl2.TabIndex = 367;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Wheat;
            this.tabPage1.Controls.Add(this.checkBoxAutoFeed);
            this.tabPage1.Controls.Add(this.label48);
            this.tabPage1.Controls.Add(this.numericUpDownWatchDogReset);
            this.tabPage1.Controls.Add(this.numericUpDownWatchDogReboot);
            this.tabPage1.Controls.Add(this.labelRtnSetWatchDog);
            this.tabPage1.Controls.Add(this.numericUpDownWatchDogExpire);
            this.tabPage1.Controls.Add(this.buttonSetWatchDog);
            this.tabPage1.Controls.Add(this.buttonFeedWatchDog);
            this.tabPage1.Controls.Add(this.labelRtnFeedWatchDog);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(382, 79);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "WatchDog Function";
            // 
            // checkBoxAutoFeed
            // 
            this.checkBoxAutoFeed.AutoSize = true;
            this.checkBoxAutoFeed.Location = new System.Drawing.Point(170, 9);
            this.checkBoxAutoFeed.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxAutoFeed.Name = "checkBoxAutoFeed";
            this.checkBoxAutoFeed.Size = new System.Drawing.Size(75, 17);
            this.checkBoxAutoFeed.TabIndex = 382;
            this.checkBoxAutoFeed.Text = "Auto Feed";
            this.checkBoxAutoFeed.UseVisualStyleBackColor = true;
            this.checkBoxAutoFeed.CheckedChanged += new System.EventHandler(this.checkBoxAutoFeed_CheckedChanged);
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.BackColor = System.Drawing.Color.Wheat;
            this.label48.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label48.Location = new System.Drawing.Point(170, 29);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(194, 17);
            this.label48.TabIndex = 381;
            this.label48.Text = "Interval / Reboot / Reset Hold";
            this.label48.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDownWatchDogReset
            // 
            this.numericUpDownWatchDogReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownWatchDogReset.Location = new System.Drawing.Point(294, 48);
            this.numericUpDownWatchDogReset.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownWatchDogReset.Name = "numericUpDownWatchDogReset";
            this.numericUpDownWatchDogReset.Size = new System.Drawing.Size(44, 22);
            this.numericUpDownWatchDogReset.TabIndex = 380;
            this.numericUpDownWatchDogReset.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numericUpDownWatchDogReboot
            // 
            this.numericUpDownWatchDogReboot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownWatchDogReboot.Location = new System.Drawing.Point(232, 48);
            this.numericUpDownWatchDogReboot.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDownWatchDogReboot.Name = "numericUpDownWatchDogReboot";
            this.numericUpDownWatchDogReboot.Size = new System.Drawing.Size(58, 22);
            this.numericUpDownWatchDogReboot.TabIndex = 379;
            this.numericUpDownWatchDogReboot.Value = new decimal(new int[] {
            1200,
            0,
            0,
            0});
            // 
            // labelRtnSetWatchDog
            // 
            this.labelRtnSetWatchDog.AutoSize = true;
            this.labelRtnSetWatchDog.BackColor = System.Drawing.Color.White;
            this.labelRtnSetWatchDog.Location = new System.Drawing.Point(141, 54);
            this.labelRtnSetWatchDog.Name = "labelRtnSetWatchDog";
            this.labelRtnSetWatchDog.Size = new System.Drawing.Size(13, 13);
            this.labelRtnSetWatchDog.TabIndex = 378;
            this.labelRtnSetWatchDog.Text = "0";
            // 
            // numericUpDownWatchDogExpire
            // 
            this.numericUpDownWatchDogExpire.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownWatchDogExpire.Location = new System.Drawing.Point(170, 48);
            this.numericUpDownWatchDogExpire.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDownWatchDogExpire.Name = "numericUpDownWatchDogExpire";
            this.numericUpDownWatchDogExpire.Size = new System.Drawing.Size(58, 22);
            this.numericUpDownWatchDogExpire.TabIndex = 377;
            this.numericUpDownWatchDogExpire.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // buttonSetWatchDog
            // 
            this.buttonSetWatchDog.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonSetWatchDog.Location = new System.Drawing.Point(17, 50);
            this.buttonSetWatchDog.Name = "buttonSetWatchDog";
            this.buttonSetWatchDog.Size = new System.Drawing.Size(118, 22);
            this.buttonSetWatchDog.TabIndex = 376;
            this.buttonSetWatchDog.Text = "Set WatchDog";
            this.buttonSetWatchDog.UseVisualStyleBackColor = false;
            this.buttonSetWatchDog.Click += new System.EventHandler(this.buttonSetWatchDog_Click);
            // 
            // buttonFeedWatchDog
            // 
            this.buttonFeedWatchDog.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonFeedWatchDog.Location = new System.Drawing.Point(17, 15);
            this.buttonFeedWatchDog.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFeedWatchDog.Name = "buttonFeedWatchDog";
            this.buttonFeedWatchDog.Size = new System.Drawing.Size(118, 23);
            this.buttonFeedWatchDog.TabIndex = 375;
            this.buttonFeedWatchDog.Text = "Feed WatchDog";
            this.buttonFeedWatchDog.UseVisualStyleBackColor = false;
            this.buttonFeedWatchDog.Click += new System.EventHandler(this.buttonFeedWatchDog_Click);
            // 
            // labelRtnFeedWatchDog
            // 
            this.labelRtnFeedWatchDog.AutoSize = true;
            this.labelRtnFeedWatchDog.BackColor = System.Drawing.Color.White;
            this.labelRtnFeedWatchDog.Location = new System.Drawing.Point(140, 20);
            this.labelRtnFeedWatchDog.Name = "labelRtnFeedWatchDog";
            this.labelRtnFeedWatchDog.Size = new System.Drawing.Size(13, 13);
            this.labelRtnFeedWatchDog.TabIndex = 374;
            this.labelRtnFeedWatchDog.Text = "0";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Wheat;
            this.tabPage2.Controls.Add(this.labelRtnSetRelayContact);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.radioButtonRelayOff);
            this.tabPage2.Controls.Add(this.radioButtonRelayOn);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(382, 79);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Relay Function";
            // 
            // labelRtnSetRelayContact
            // 
            this.labelRtnSetRelayContact.AutoSize = true;
            this.labelRtnSetRelayContact.BackColor = System.Drawing.Color.White;
            this.labelRtnSetRelayContact.Location = new System.Drawing.Point(287, 48);
            this.labelRtnSetRelayContact.Name = "labelRtnSetRelayContact";
            this.labelRtnSetRelayContact.Size = new System.Drawing.Size(13, 13);
            this.labelRtnSetRelayContact.TabIndex = 289;
            this.labelRtnSetRelayContact.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Wheat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(12, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(369, 17);
            this.label6.TabIndex = 288;
            this.label6.Text = "Do not use this function when WatchDog timer is running.";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioButtonRelayOff
            // 
            this.radioButtonRelayOff.AutoSize = true;
            this.radioButtonRelayOff.Checked = true;
            this.radioButtonRelayOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.17801F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonRelayOff.Location = new System.Drawing.Point(192, 43);
            this.radioButtonRelayOff.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonRelayOff.Name = "radioButtonRelayOff";
            this.radioButtonRelayOff.Size = new System.Drawing.Size(53, 21);
            this.radioButtonRelayOff.TabIndex = 1;
            this.radioButtonRelayOff.TabStop = true;
            this.radioButtonRelayOff.Text = "OFF";
            this.radioButtonRelayOff.UseVisualStyleBackColor = true;
            this.radioButtonRelayOff.CheckedChanged += new System.EventHandler(this.radioButtonRelayOff_CheckedChanged);
            // 
            // radioButtonRelayOn
            // 
            this.radioButtonRelayOn.AutoSize = true;
            this.radioButtonRelayOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.17801F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonRelayOn.Location = new System.Drawing.Point(78, 43);
            this.radioButtonRelayOn.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonRelayOn.Name = "radioButtonRelayOn";
            this.radioButtonRelayOn.Size = new System.Drawing.Size(47, 21);
            this.radioButtonRelayOn.TabIndex = 0;
            this.radioButtonRelayOn.Text = "ON";
            this.radioButtonRelayOn.UseVisualStyleBackColor = true;
            this.radioButtonRelayOn.CheckedChanged += new System.EventHandler(this.radioButtonRelayOn_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(19, 721);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(474, 5);
            this.groupBox3.TabIndex = 368;
            this.groupBox3.TabStop = false;
            // 
            // timerAutoFeed
            // 
            this.timerAutoFeed.Interval = 1000;
            this.timerAutoFeed.Tick += new System.EventHandler(this.timerAutoFeed_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1015, 759);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.labelMDBCoinCondition);
            this.Controls.Add(this.labelMDBBillCondition);
            this.Controls.Add(this.label47);
            this.Controls.Add(this.label46);
            this.Controls.Add(this.label103);
            this.Controls.Add(this.label79);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.labelRtnCancelMDBBillPayout);
            this.Controls.Add(this.buttonCancelMDBBillPayout);
            this.Controls.Add(this.label51);
            this.Controls.Add(this.label110);
            this.Controls.Add(this.label111);
            this.Controls.Add(this.numericUpDownDispenseMDBBillsByType2);
            this.Controls.Add(this.numericUpDownDispenseMDBBillsByType1);
            this.Controls.Add(this.labelPollMDBBillPayoutString);
            this.Controls.Add(this.label113);
            this.Controls.Add(this.label114);
            this.Controls.Add(this.label115);
            this.Controls.Add(this.label116);
            this.Controls.Add(this.buttonDispenseMDBBillsByType);
            this.Controls.Add(this.labelRtnDispenseMDBBillsByType);
            this.Controls.Add(this.buttonDispenseMDBBillsByValue);
            this.Controls.Add(this.labelRtnPollMDBBillPayout);
            this.Controls.Add(this.buttonPollMDBBillPayout);
            this.Controls.Add(this.labelRtnDispenseMDBBillsByValue);
            this.Controls.Add(this.labelCoinStatusLightBox_EscrowLever);
            this.Controls.Add(this.labelBillStatusLightBox_RecyclerDisabled);
            this.Controls.Add(this.labelBillStatusLightBox_EscrowButton);
            this.Controls.Add(this.labelBillStatusLightBox_FillButton);
            this.Controls.Add(this.label101);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.labelBillStatusLightBox_ManualFilledAmount);
            this.Controls.Add(this.labelBillStatusLightBox_ManualFilled);
            this.Controls.Add(this.tabPageGetRouteEnable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonMDBBillEscrowReturn);
            this.Controls.Add(this.buttonMDBBillEscrowAccept);
            this.Controls.Add(this.checkBoxMDBBillAutoAccept);
            this.Controls.Add(this.labelBillStatusLightBox_InvalidEscrow);
            this.Controls.Add(this.label71);
            this.Controls.Add(this.labelBillStatusLightBox_EscrowedAmount);
            this.Controls.Add(this.labelBillStatusLightBox_Escrowed);
            this.Controls.Add(this.label69);
            this.Controls.Add(this.labelBillStatusLightBox_TransferredAmount);
            this.Controls.Add(this.labelBillStatusLightBox_CassetteProblem);
            this.Controls.Add(this.labelBillStatusLightBox_Stacking);
            this.Controls.Add(this.labelBillStatusLightBox_Rejecting);
            this.Controls.Add(this.labelBillStatusLightBox_Rejected);
            this.Controls.Add(this.numericUpDownDispenseMDBBillsByValue);
            this.Controls.Add(this.label52);
            this.Controls.Add(this.labelBillStatusLightBox_Transferred);
            this.Controls.Add(this.labelBillStatusLightBox_Credit2RE);
            this.Controls.Add(this.labelBillStatusLightBox_Credit2CB);
            this.Controls.Add(this.buttonClearBillAmount);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.labelBillStatusLightBox_ManualDispensedAmount);
            this.Controls.Add(this.labelBillStatusLightBox_CreditAmount);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.labelBillStatusLightBox_NoComm);
            this.Controls.Add(this.labelBillStatusLightBox_Failure);
            this.Controls.Add(this.labelBillStatusLightBox_Jammed);
            this.Controls.Add(this.labelBillStatusLightBox_ManualDispensed);
            this.Controls.Add(this.labelBillStatusLightBox_Credit);
            this.Controls.Add(this.labelBillStatusLightBox_Cheated);
            this.Controls.Add(this.labelBillStatusLightBox_Disabled);
            this.Controls.Add(this.labelBillStatusLightBox_Reset);
            this.Controls.Add(this.labelBillStatusLightBox_Idle);
            this.Controls.Add(this.buttonGetMDBBillSetup);
            this.Controls.Add(this.labelRtnGetMDBBillSetup);
            this.Controls.Add(this.labelBillISO);
            this.Controls.Add(this.label53);
            this.Controls.Add(this.label54);
            this.Controls.Add(this.label55);
            this.Controls.Add(this.label56);
            this.Controls.Add(this.label57);
            this.Controls.Add(this.label58);
            this.Controls.Add(this.label59);
            this.Controls.Add(this.label60);
            this.Controls.Add(this.labelBillDecimal);
            this.Controls.Add(this.labelBillScale);
            this.Controls.Add(this.labelBillLevel);
            this.Controls.Add(this.labelBillCh15);
            this.Controls.Add(this.labelBillCh14);
            this.Controls.Add(this.labelBillCh13);
            this.Controls.Add(this.labelBillCh12);
            this.Controls.Add(this.labelBillCh11);
            this.Controls.Add(this.labelBillCh10);
            this.Controls.Add(this.labelBillCh9);
            this.Controls.Add(this.labelBillCh8);
            this.Controls.Add(this.labelBillCh7);
            this.Controls.Add(this.labelBillCh6);
            this.Controls.Add(this.labelBillCh5);
            this.Controls.Add(this.labelBillCh4);
            this.Controls.Add(this.labelBillCh3);
            this.Controls.Add(this.labelBillCh2);
            this.Controls.Add(this.labelBillCh1);
            this.Controls.Add(this.labelBillCh0);
            this.Controls.Add(this.label83);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.labelCoinStatusLightBox_Credit2RJ);
            this.Controls.Add(this.labelCoinStatusLightBox_Credit2TU);
            this.Controls.Add(this.labelCoinStatusLightBox_Credit2CB);
            this.Controls.Add(this.buttonClearCoinAmount);
            this.Controls.Add(this.label45);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.labelCoinStatusLightBox_ManualAmount);
            this.Controls.Add(this.labelCoinStatusLightBox_CreditAmount);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.labelCoinStatusLightBox_NoComm);
            this.Controls.Add(this.labelCoinStatusLightBox_Failure);
            this.Controls.Add(this.labelCoinStatusLightBox_Jammed);
            this.Controls.Add(this.labelCoinStatusLightBox_Manual);
            this.Controls.Add(this.labelCoinStatusLightBox_Credit);
            this.Controls.Add(this.labelCoinStatusLightBox_Cheated);
            this.Controls.Add(this.labelCoinStatusLightBox_Disabled);
            this.Controls.Add(this.labelCoinStatusLightBox_Reset);
            this.Controls.Add(this.labelCoinStatusLightBox_Idle);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDownDispenseMDBCoinsByValue);
            this.Controls.Add(this.numericUpDownDispenseMDBCoinsByType2);
            this.Controls.Add(this.numericUpDownDispenseMDBCoinsByType1);
            this.Controls.Add(this.labelPollMDBCoinPayoutString);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label63);
            this.Controls.Add(this.label62);
            this.Controls.Add(this.label61);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.buttonDispenseMDBCoinsByType);
            this.Controls.Add(this.labelRtnDispenseMDBCoinsByType);
            this.Controls.Add(this.buttonDispenseMDBCoinsByValue);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonGetMDBCoinSetup);
            this.Controls.Add(this.labelMiscMDBCmdRepliedString);
            this.Controls.Add(this.labelRtnGetMDBCoinSetup);
            this.Controls.Add(this.labelCoinISO);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelRtnPollMDBCoinPayout);
            this.Controls.Add(this.buttonPollMDBCoinPayout);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelCoinDecimal);
            this.Controls.Add(this.labelCoinScale);
            this.Controls.Add(this.labelCoinLevel);
            this.Controls.Add(this.labelCoinCh15);
            this.Controls.Add(this.labelCoinCh14);
            this.Controls.Add(this.labelCoinCh13);
            this.Controls.Add(this.labelCoinCh12);
            this.Controls.Add(this.labelCoinCh11);
            this.Controls.Add(this.labelCoinCh10);
            this.Controls.Add(this.labelCoinCh9);
            this.Controls.Add(this.labelCoinCh8);
            this.Controls.Add(this.labelCoinCh7);
            this.Controls.Add(this.labelCoinCh6);
            this.Controls.Add(this.labelCoinCh5);
            this.Controls.Add(this.labelCoinCh4);
            this.Controls.Add(this.labelCoinCh3);
            this.Controls.Add(this.labelCoinCh2);
            this.Controls.Add(this.labelCoinCh1);
            this.Controls.Add(this.labelCoinCh0);
            this.Controls.Add(this.labelRtnDispenseMDBCoinsByValue);
            this.Controls.Add(this.buttonGetMDBCoinStatus);
            this.Controls.Add(this.labelGetMDBCoinStatusString);
            this.Controls.Add(this.labelRtnGetMDBCoinStatus);
            this.Controls.Add(this.checkBoxAutoCoin);
            this.Controls.Add(this.checkBoxAutoBill);
            this.Controls.Add(this.buttonGetMDBBillStatus);
            this.Controls.Add(this.buttonResetMDB);
            this.Controls.Add(this.buttonGetKernelVersion);
            this.Controls.Add(this.buttonPingIPC);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelGetMDBBillStatusString);
            this.Controls.Add(this.labelRtnGetMDBBillStatus);
            this.Controls.Add(this.buttonGetSerialNumber);
            this.Controls.Add(this.labelGetKernelVersionString);
            this.Controls.Add(this.labelRtnGetKernelVersion);
            this.Controls.Add(this.labelRtnPingIPC);
            this.Controls.Add(this.labelRtnResetMDB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelGetSerialNumberString);
            this.Controls.Add(this.labelRtnGetSerialNumber);
            this.Controls.Add(this.buttonCloseCOM);
            this.Controls.Add(this.buttonOpenCOM);
            this.Controls.Add(this.labelRtnCloseCOM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCOMPort);
            this.Controls.Add(this.labelDLLVer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelRtnOpenCOM);
            this.Name = "Form1";
            this.Text = "IPC-1 Demo v1.2.0.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageSetCoinEnable.ResumeLayout(false);
            this.tabPageSetCoinEnable.PerformLayout();
            this.tabPageCoinTubeContent.ResumeLayout(false);
            this.tabPageCoinTubeContent.PerformLayout();
            this.tabPageCoinPayoutFinal.ResumeLayout(false);
            this.tabPageCoinPayoutFinal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDispenseMDBCoinsByType1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDispenseMDBCoinsByType2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDispenseMDBCoinsByValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDispenseMDBBillsByValue)).EndInit();
            this.tabPageGetRouteEnable.ResumeLayout(false);
            this.tabPageSetBillEnable.ResumeLayout(false);
            this.tabPageSetBillEnable.PerformLayout();
            this.tabPageGetBillRouteTable.ResumeLayout(false);
            this.tabPageGetBillRouteTable.PerformLayout();
            this.tabPageSetBillRouteEnable.ResumeLayout(false);
            this.tabPageSetBillRouteEnable.PerformLayout();
            this.tabPageRecyclerContent.ResumeLayout(false);
            this.tabPageRecyclerContent.PerformLayout();
            this.tabPageRecyclerPayoutFinal.ResumeLayout(false);
            this.tabPageRecyclerPayoutFinal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDispenseMDBBillsByType2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDispenseMDBBillsByType1)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWatchDogReset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWatchDogReboot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWatchDogExpire)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRtnOpenCOM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelDLLVer;
        private System.Windows.Forms.TextBox textBoxCOMPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelRtnCloseCOM;
        private System.Windows.Forms.Button buttonOpenCOM;
        private System.Windows.Forms.Button buttonCloseCOM;
        private System.Windows.Forms.Label labelRtnGetSerialNumber;
        private System.Windows.Forms.Label labelGetSerialNumberString;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelRtnResetMDB;
        private System.Windows.Forms.Label labelRtnPingIPC;
        private System.Windows.Forms.Label labelGetKernelVersionString;
        private System.Windows.Forms.Label labelRtnGetKernelVersion;
        private System.Windows.Forms.Button buttonGetSerialNumber;
        private System.Windows.Forms.Label labelGetMDBBillStatusString;
        private System.Windows.Forms.Label labelRtnGetMDBBillStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button buttonPingIPC;
        private System.Windows.Forms.Button buttonGetKernelVersion;
        private System.Windows.Forms.Button buttonResetMDB;
        private System.Windows.Forms.Button buttonGetMDBBillStatus;
        private System.Windows.Forms.Timer timerAutoPoll;
        private System.Windows.Forms.CheckBox checkBoxAutoBill;
        private System.Windows.Forms.CheckBox checkBoxAutoCoin;
        private System.Windows.Forms.Button buttonGetMDBCoinStatus;
        private System.Windows.Forms.Label labelGetMDBCoinStatusString;
        private System.Windows.Forms.Label labelRtnGetMDBCoinStatus;
        private System.Windows.Forms.Label labelRtnDispenseMDBCoinsByValue;
        private System.Windows.Forms.Label labelRtnGetMDBCoinPayoutFinal;
        private System.Windows.Forms.Label labelRtnSetMDBCoinChannels;
        private System.Windows.Forms.Button buttonSetMDBCoinChannels;
        private System.Windows.Forms.Button buttonGetMDBCoinPayoutFinal;
        private System.Windows.Forms.Button buttonPollMDBCoinPayout;
        private System.Windows.Forms.Label labelRtnPollMDBCoinPayout;
        private System.Windows.Forms.Label labelCoinCh0;
        private System.Windows.Forms.Label labelCoinCh1;
        private System.Windows.Forms.Label labelCoinCh2;
        private System.Windows.Forms.Label labelCoinCh3;
        private System.Windows.Forms.Label labelCoinCh7;
        private System.Windows.Forms.Label labelCoinCh6;
        private System.Windows.Forms.Label labelCoinCh5;
        private System.Windows.Forms.Label labelCoinCh4;
        private System.Windows.Forms.Label labelCoinCh11;
        private System.Windows.Forms.Label labelCoinCh10;
        private System.Windows.Forms.Label labelCoinCh9;
        private System.Windows.Forms.Label labelCoinCh8;
        private System.Windows.Forms.Label labelCoinCh15;
        private System.Windows.Forms.Label labelCoinCh14;
        private System.Windows.Forms.Label labelCoinCh13;
        private System.Windows.Forms.Label labelCoinCh12;
        private System.Windows.Forms.Label labelCoinLevel;
        private System.Windows.Forms.Label labelCoinScale;
        private System.Windows.Forms.Label labelCoinDecimal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label labelCoinISO;
        private System.Windows.Forms.Button buttonGetMDBCoinSetup;
        private System.Windows.Forms.Label labelMiscMDBCmdRepliedString;
        private System.Windows.Forms.Label labelRtnGetMDBCoinSetup;
        private System.Windows.Forms.CheckBox checkBoxCoinEnable0;
        private System.Windows.Forms.CheckBox checkBoxCoinEnable1;
        private System.Windows.Forms.CheckBox checkBoxCoinEnable2;
        private System.Windows.Forms.CheckBox checkBoxCoinEnable3;
        private System.Windows.Forms.CheckBox checkBoxCoinEnable4;
        private System.Windows.Forms.CheckBox checkBoxCoinEnable5;
        private System.Windows.Forms.CheckBox checkBoxCoinEnable6;
        private System.Windows.Forms.CheckBox checkBoxCoinEnable7;
        private System.Windows.Forms.CheckBox checkBoxCoinEnable11;
        private System.Windows.Forms.CheckBox checkBoxCoinEnable10;
        private System.Windows.Forms.CheckBox checkBoxCoinEnable9;
        private System.Windows.Forms.CheckBox checkBoxCoinEnable8;
        private System.Windows.Forms.CheckBox checkBoxCoinEnable15;
        private System.Windows.Forms.CheckBox checkBoxCoinEnable14;
        private System.Windows.Forms.CheckBox checkBoxCoinEnable13;
        private System.Windows.Forms.CheckBox checkBoxCoinEnable12;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageSetCoinEnable;
        private System.Windows.Forms.TabPage tabPageCoinTubeContent;
        private System.Windows.Forms.Label labelRtnGetMDBCoinTubeContent;
        private System.Windows.Forms.Button buttonGetMDBCoinTubeContent;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label labelTube15;
        private System.Windows.Forms.Label labelTube14;
        private System.Windows.Forms.Label labelTube13;
        private System.Windows.Forms.Label labelTube12;
        private System.Windows.Forms.Label labelTube11;
        private System.Windows.Forms.Label labelTube10;
        private System.Windows.Forms.Label labelTube9;
        private System.Windows.Forms.Label labelTube8;
        private System.Windows.Forms.Label labelTube7;
        private System.Windows.Forms.Label labelTube6;
        private System.Windows.Forms.Label labelTube5;
        private System.Windows.Forms.Label labelTube4;
        private System.Windows.Forms.Label labelTube3;
        private System.Windows.Forms.Label labelTube2;
        private System.Windows.Forms.Label labelTube1;
        private System.Windows.Forms.Label labelTube0;
        private System.Windows.Forms.TabPage tabPageCoinPayoutFinal;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label labelCoinPayoutFinal15;
        private System.Windows.Forms.Label labelCoinPayoutFinal14;
        private System.Windows.Forms.Label labelCoinPayoutFinal13;
        private System.Windows.Forms.Label labelCoinPayoutFinal12;
        private System.Windows.Forms.Label labelCoinPayoutFinal11;
        private System.Windows.Forms.Label labelCoinPayoutFinal10;
        private System.Windows.Forms.Label labelCoinPayoutFinal9;
        private System.Windows.Forms.Label labelCoinPayoutFinal8;
        private System.Windows.Forms.Label labelCoinPayoutFinal7;
        private System.Windows.Forms.Label labelCoinPayoutFinal6;
        private System.Windows.Forms.Label labelCoinPayoutFinal5;
        private System.Windows.Forms.Label labelCoinPayoutFinal4;
        private System.Windows.Forms.Label labelCoinPayoutFinal3;
        private System.Windows.Forms.Label labelCoinPayoutFinal2;
        private System.Windows.Forms.Label labelCoinPayoutFinal1;
        private System.Windows.Forms.Label labelCoinPayoutFinal0;
        private System.Windows.Forms.Button buttonDispenseMDBCoinsByValue;
        private System.Windows.Forms.Button buttonDispenseMDBCoinsByType;
        private System.Windows.Forms.Label labelRtnDispenseMDBCoinsByType;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label labelPollMDBCoinPayoutString;
        private System.Windows.Forms.NumericUpDown numericUpDownDispenseMDBCoinsByType1;
        private System.Windows.Forms.NumericUpDown numericUpDownDispenseMDBCoinsByType2;
        private System.Windows.Forms.NumericUpDown numericUpDownDispenseMDBCoinsByValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label labelGetMDBCoinPayoutFinalAckOnly;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label labelCoinStatusLightBox_Idle;
        private System.Windows.Forms.Label labelCoinStatusLightBox_Reset;
        private System.Windows.Forms.Label labelCoinStatusLightBox_Disabled;
        private System.Windows.Forms.Label labelCoinStatusLightBox_Cheated;
        private System.Windows.Forms.Label labelCoinStatusLightBox_Credit;
        private System.Windows.Forms.Label labelCoinStatusLightBox_Manual;
        private System.Windows.Forms.Label labelCoinStatusLightBox_Jammed;
        private System.Windows.Forms.Label labelCoinStatusLightBox_Failure;
        private System.Windows.Forms.Label labelCoinStatusLightBox_NoComm;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label labelCoinStatusLightBox_CreditAmount;
        private System.Windows.Forms.Label labelCoinStatusLightBox_ManualAmount;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Button buttonClearCoinAmount;
        private System.Windows.Forms.Label labelCoinStatusLightBox_Credit2CB;
        private System.Windows.Forms.Label labelCoinStatusLightBox_Credit2TU;
        private System.Windows.Forms.Label labelCoinStatusLightBox_Credit2RJ;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label labelBillStatusLightBox_Transferred;
        private System.Windows.Forms.Label labelBillStatusLightBox_Credit2RE;
        private System.Windows.Forms.Label labelBillStatusLightBox_Credit2CB;
        private System.Windows.Forms.Button buttonClearBillAmount;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label labelBillStatusLightBox_ManualDispensedAmount;
        private System.Windows.Forms.Label labelBillStatusLightBox_CreditAmount;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label labelBillStatusLightBox_NoComm;
        private System.Windows.Forms.Label labelBillStatusLightBox_Failure;
        private System.Windows.Forms.Label labelBillStatusLightBox_Jammed;
        private System.Windows.Forms.Label labelBillStatusLightBox_ManualDispensed;
        private System.Windows.Forms.Label labelBillStatusLightBox_Credit;
        private System.Windows.Forms.Label labelBillStatusLightBox_Cheated;
        private System.Windows.Forms.Label labelBillStatusLightBox_Disabled;
        private System.Windows.Forms.Label labelBillStatusLightBox_Reset;
        private System.Windows.Forms.Label labelBillStatusLightBox_Idle;
        private System.Windows.Forms.Button buttonGetMDBBillSetup;
        private System.Windows.Forms.Label labelRtnGetMDBBillSetup;
        private System.Windows.Forms.Label labelBillISO;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label labelBillDecimal;
        private System.Windows.Forms.Label labelBillScale;
        private System.Windows.Forms.Label labelBillLevel;
        private System.Windows.Forms.Label labelBillCh15;
        private System.Windows.Forms.Label labelBillCh14;
        private System.Windows.Forms.Label labelBillCh13;
        private System.Windows.Forms.Label labelBillCh12;
        private System.Windows.Forms.Label labelBillCh11;
        private System.Windows.Forms.Label labelBillCh10;
        private System.Windows.Forms.Label labelBillCh9;
        private System.Windows.Forms.Label labelBillCh8;
        private System.Windows.Forms.Label labelBillCh7;
        private System.Windows.Forms.Label labelBillCh6;
        private System.Windows.Forms.Label labelBillCh5;
        private System.Windows.Forms.Label labelBillCh4;
        private System.Windows.Forms.Label labelBillCh3;
        private System.Windows.Forms.Label labelBillCh2;
        private System.Windows.Forms.Label labelBillCh1;
        private System.Windows.Forms.Label labelBillCh0;
        private System.Windows.Forms.Label label83;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.NumericUpDown numericUpDownDispenseMDBBillsByValue;
        private System.Windows.Forms.Label labelBillStatusLightBox_Rejected;
        private System.Windows.Forms.Label labelBillStatusLightBox_Rejecting;
        private System.Windows.Forms.Label labelBillStatusLightBox_Stacking;
        private System.Windows.Forms.Label labelBillStatusLightBox_CassetteProblem;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.Label labelBillStatusLightBox_TransferredAmount;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.Label labelBillStatusLightBox_EscrowedAmount;
        private System.Windows.Forms.Label labelBillStatusLightBox_Escrowed;
        private System.Windows.Forms.Label labelBillStatusLightBox_InvalidEscrow;
        private System.Windows.Forms.CheckBox checkBoxMDBBillAutoAccept;
        private System.Windows.Forms.Button buttonMDBBillEscrowAccept;
        private System.Windows.Forms.Button buttonMDBBillEscrowReturn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabPageGetRouteEnable;
        private System.Windows.Forms.TabPage tabPageSetBillEnable;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonSetMDBBillChannels;
        private System.Windows.Forms.CheckBox checkBoxBillEnable15;
        private System.Windows.Forms.CheckBox checkBoxBillEnable14;
        private System.Windows.Forms.Label labelRtnSetMDBBillChannels;
        private System.Windows.Forms.CheckBox checkBoxBillEnable13;
        private System.Windows.Forms.CheckBox checkBoxBillEnable12;
        private System.Windows.Forms.CheckBox checkBoxBillEnable0;
        private System.Windows.Forms.CheckBox checkBoxBillEnable11;
        private System.Windows.Forms.CheckBox checkBoxBillEnable1;
        private System.Windows.Forms.CheckBox checkBoxBillEnable10;
        private System.Windows.Forms.CheckBox checkBoxBillEnable2;
        private System.Windows.Forms.CheckBox checkBoxBillEnable9;
        private System.Windows.Forms.CheckBox checkBoxBillEnable3;
        private System.Windows.Forms.CheckBox checkBoxBillEnable8;
        private System.Windows.Forms.CheckBox checkBoxBillEnable4;
        private System.Windows.Forms.CheckBox checkBoxBillEnable7;
        private System.Windows.Forms.CheckBox checkBoxBillEnable5;
        private System.Windows.Forms.CheckBox checkBoxBillEnable6;
        private System.Windows.Forms.TabPage tabPageGetBillRouteTable;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label labelRtnGetMDBRecyclerRouteTable;
        private System.Windows.Forms.Button buttonGetMDBRecyclerRouteTable;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label labelRouteTable15;
        private System.Windows.Forms.Label labelRouteTable14;
        private System.Windows.Forms.Label labelRouteTable13;
        private System.Windows.Forms.Label labelRouteTable12;
        private System.Windows.Forms.Label labelRouteTable11;
        private System.Windows.Forms.Label labelRouteTable10;
        private System.Windows.Forms.Label labelRouteTable9;
        private System.Windows.Forms.Label labelRouteTable8;
        private System.Windows.Forms.Label labelRouteTable7;
        private System.Windows.Forms.Label labelRouteTable6;
        private System.Windows.Forms.Label labelRouteTable5;
        private System.Windows.Forms.Label labelRouteTable4;
        private System.Windows.Forms.Label labelRouteTable3;
        private System.Windows.Forms.Label labelRouteTable2;
        private System.Windows.Forms.Label labelRouteTable1;
        private System.Windows.Forms.Label labelRouteTable0;
        private System.Windows.Forms.TabPage tabPageSetBillRouteEnable;
        private System.Windows.Forms.Label labelBillStatusLightBox_ManualFilled;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label labelBillStatusLightBox_ManualFilledAmount;
        private System.Windows.Forms.Label label101;
        private System.Windows.Forms.Label labelBillStatusLightBox_FillButton;
        private System.Windows.Forms.Label labelBillStatusLightBox_EscrowButton;
        private System.Windows.Forms.Label labelBillStatusLightBox_RecyclerDisabled;
        private System.Windows.Forms.Label labelCoinStatusLightBox_EscrowLever;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.Button buttonSetMDBRecyclerRouteEnable;
        private System.Windows.Forms.CheckBox checkBoxRouteEnable15;
        private System.Windows.Forms.CheckBox checkBoxRouteEnable14;
        private System.Windows.Forms.Label labelRtnSetMDBRecyclerRouteEnable;
        private System.Windows.Forms.CheckBox checkBoxRouteEnable13;
        private System.Windows.Forms.CheckBox checkBoxRouteEnable12;
        private System.Windows.Forms.CheckBox checkBoxRouteEnable0;
        private System.Windows.Forms.CheckBox checkBoxRouteEnable11;
        private System.Windows.Forms.CheckBox checkBoxRouteEnable1;
        private System.Windows.Forms.CheckBox checkBoxRouteEnable10;
        private System.Windows.Forms.CheckBox checkBoxRouteEnable2;
        private System.Windows.Forms.CheckBox checkBoxRouteEnable9;
        private System.Windows.Forms.CheckBox checkBoxRouteEnable3;
        private System.Windows.Forms.CheckBox checkBoxRouteEnable8;
        private System.Windows.Forms.CheckBox checkBoxRouteEnable4;
        private System.Windows.Forms.CheckBox checkBoxRouteEnable7;
        private System.Windows.Forms.CheckBox checkBoxRouteEnable5;
        private System.Windows.Forms.CheckBox checkBoxRouteEnable6;
        private System.Windows.Forms.TabPage tabPageRecyclerContent;
        private System.Windows.Forms.Label label82;
        private System.Windows.Forms.Label labelRtnGetMDBRecyclerContent;
        private System.Windows.Forms.Button buttonGetMDBRecyclerContent;
        private System.Windows.Forms.Label label85;
        private System.Windows.Forms.Label label86;
        private System.Windows.Forms.Label label87;
        private System.Windows.Forms.Label label88;
        private System.Windows.Forms.Label labelRecyclerContent15;
        private System.Windows.Forms.Label labelRecyclerContent14;
        private System.Windows.Forms.Label labelRecyclerContent13;
        private System.Windows.Forms.Label labelRecyclerContent12;
        private System.Windows.Forms.Label labelRecyclerContent11;
        private System.Windows.Forms.Label labelRecyclerContent10;
        private System.Windows.Forms.Label labelRecyclerContent9;
        private System.Windows.Forms.Label labelRecyclerContent8;
        private System.Windows.Forms.Label labelRecyclerContent7;
        private System.Windows.Forms.Label labelRecyclerContent6;
        private System.Windows.Forms.Label labelRecyclerContent5;
        private System.Windows.Forms.Label labelRecyclerContent4;
        private System.Windows.Forms.Label labelRecyclerContent3;
        private System.Windows.Forms.Label labelRecyclerContent2;
        private System.Windows.Forms.Label labelRecyclerContent1;
        private System.Windows.Forms.Label labelRecyclerContent0;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label110;
        private System.Windows.Forms.Label label111;
        private System.Windows.Forms.NumericUpDown numericUpDownDispenseMDBBillsByType2;
        private System.Windows.Forms.NumericUpDown numericUpDownDispenseMDBBillsByType1;
        private System.Windows.Forms.Label labelPollMDBBillPayoutString;
        private System.Windows.Forms.Label label113;
        private System.Windows.Forms.Label label114;
        private System.Windows.Forms.Label label115;
        private System.Windows.Forms.Label label116;
        private System.Windows.Forms.Button buttonDispenseMDBBillsByType;
        private System.Windows.Forms.Label labelRtnDispenseMDBBillsByType;
        private System.Windows.Forms.Button buttonDispenseMDBBillsByValue;
        private System.Windows.Forms.Label labelRtnPollMDBBillPayout;
        private System.Windows.Forms.Button buttonPollMDBBillPayout;
        private System.Windows.Forms.Label labelRtnDispenseMDBBillsByValue;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label labelRtnCancelMDBBillPayout;
        private System.Windows.Forms.Button buttonCancelMDBBillPayout;
        private System.Windows.Forms.TabPage tabPageRecyclerPayoutFinal;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.Label labelGetMDBRecyclerPayoutFinalAckOnly;
        private System.Windows.Forms.Label label80;
        private System.Windows.Forms.Label label81;
        private System.Windows.Forms.Label label84;
        private System.Windows.Forms.Label label102;
        private System.Windows.Forms.Label labelRecyclerPayoutFinal15;
        private System.Windows.Forms.Label labelRecyclerPayoutFinal14;
        private System.Windows.Forms.Label labelRecyclerPayoutFinal13;
        private System.Windows.Forms.Label labelRecyclerPayoutFinal12;
        private System.Windows.Forms.Label labelRecyclerPayoutFinal11;
        private System.Windows.Forms.Label labelRecyclerPayoutFinal10;
        private System.Windows.Forms.Label labelRecyclerPayoutFinal9;
        private System.Windows.Forms.Label labelRecyclerPayoutFinal8;
        private System.Windows.Forms.Label labelRecyclerPayoutFinal7;
        private System.Windows.Forms.Label labelRecyclerPayoutFinal6;
        private System.Windows.Forms.Label labelRecyclerPayoutFinal5;
        private System.Windows.Forms.Label labelRecyclerPayoutFinal4;
        private System.Windows.Forms.Label labelRecyclerPayoutFinal3;
        private System.Windows.Forms.Label labelRecyclerPayoutFinal2;
        private System.Windows.Forms.Label labelRecyclerPayoutFinal1;
        private System.Windows.Forms.Label labelRecyclerPayoutFinal0;
        private System.Windows.Forms.Button buttonGetMDBRecyclerPayoutFinal;
        private System.Windows.Forms.Label labelRtnGetMDBRecyclerPayoutFinal;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.Label label103;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label labelMDBBillCondition;
        private System.Windows.Forms.Label labelMDBCoinCondition;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.NumericUpDown numericUpDownWatchDogReset;
        private System.Windows.Forms.NumericUpDown numericUpDownWatchDogReboot;
        private System.Windows.Forms.Label labelRtnSetWatchDog;
        private System.Windows.Forms.NumericUpDown numericUpDownWatchDogExpire;
        private System.Windows.Forms.Button buttonSetWatchDog;
        private System.Windows.Forms.Button buttonFeedWatchDog;
        private System.Windows.Forms.Label labelRtnFeedWatchDog;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButtonRelayOff;
        private System.Windows.Forms.RadioButton radioButtonRelayOn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.CheckBox checkBoxAutoFeed;
        private System.Windows.Forms.Timer timerAutoFeed;
        private System.Windows.Forms.Label labelRtnSetRelayContact;
    }
}

