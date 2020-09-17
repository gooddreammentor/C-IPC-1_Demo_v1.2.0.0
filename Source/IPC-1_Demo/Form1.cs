using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MfxIpcLib;

namespace DLLtester
{
    public partial class Form1 : Form
    {

        IPCclass SR1 = new IPCclass();

        int autoPollSeq = 0;        // 0 = bill status | 1 = coin status
        int lastCoinEventCounter = 0;
        int lastBillEventCounter = 0;
        bool firstCoinPoll = true;
        bool firstBillPoll = true;

        int pollRateChange = 0;

        public Form1()
        {
            InitializeComponent();
            ToolTip toolTip1 = new System.Windows.Forms.ToolTip();
            // coin
            toolTip1.SetToolTip(buttonGetMDBCoinSetup, "Retrieve coin charger setup data. This should be the first command before other operations.");
            toolTip1.SetToolTip(buttonGetMDBCoinStatus, "Retrieve 12 most recent events.");
            toolTip1.SetToolTip(checkBoxAutoCoin, "Automatic poll for events");
            toolTip1.SetToolTip(buttonSetMDBCoinChannels, "Check above boxes to enable coin channels. Uncheck all to disable coin acceptor.");
            toolTip1.SetToolTip(buttonGetMDBCoinTubeContent, "Retrieve the greatest number of coins that the changer knows definitely are present.");
            toolTip1.SetToolTip(buttonGetMDBCoinPayoutFinal, "Use once and only after a dispense operation for coin types and number of coins that have been paid out.");
            toolTip1.SetToolTip(buttonDispenseMDBCoinsByType, "Dispense coins by their channel number. Use 'Payout Final' to get operation result.");
            toolTip1.SetToolTip(buttonDispenseMDBCoinsByValue, "Dispense coins by entering the amount you want. Use 'Payout Final' to get operation result");
            toolTip1.SetToolTip(buttonPollMDBCoinPayout, "Retrieve the amount of paid out during a coin dispense operation. Amount is reset after each query. If reply=Ack, that means not in dispense operation.");
            toolTip1.SetToolTip(buttonClearCoinAmount, "Clear amount records");

            // bill
            toolTip1.SetToolTip(buttonGetMDBBillSetup, "Retrieve bill acceptor setup data. This should be the first command before other operations.");
            toolTip1.SetToolTip(buttonGetMDBBillStatus, "Retrieve 12 most recent events.");
            toolTip1.SetToolTip(checkBoxAutoBill, "Automatic poll for events");
            toolTip1.SetToolTip(buttonSetMDBBillChannels, "Check above boxes to enable each bill channels. Uncheck all to disable bill acceptor.");
            toolTip1.SetToolTip(buttonGetMDBRecyclerRouteTable, "Retrieve routing ability. '1'= able to route to RE. '0'= unable to route to RE.");
            toolTip1.SetToolTip(buttonSetMDBRecyclerRouteEnable, "Check above boxes to enable which bill types can be routed to RE.");
            toolTip1.SetToolTip(buttonGetMDBRecyclerContent, "Retrieve the greatest number of bills that the recycler knows definitely are present.");
            toolTip1.SetToolTip(buttonGetMDBRecyclerPayoutFinal, "Use once and only after a dispense operation for bill types and number of bills that have been paid out.");
            toolTip1.SetToolTip(buttonDispenseMDBBillsByType, "Dispense bills by their channel number. Use 'Payout Final' to get operation result.");
            toolTip1.SetToolTip(buttonDispenseMDBBillsByValue, "Dispense bills by entering the amount you want. Use 'Payout Final' to get operation result");
            toolTip1.SetToolTip(buttonPollMDBBillPayout, "Retrieve the amount of paid out during a bill dispense operation. Amount is reset after each query. If reply=Ack, that means not in dispense operation.");
            toolTip1.SetToolTip(buttonCancelMDBBillPayout, "Cancel bill dispense.");
            toolTip1.SetToolTip(buttonMDBBillEscrowAccept, "Accept escrowed bill.");
            toolTip1.SetToolTip(buttonMDBBillEscrowReturn, "Return escrowed bill.");
            toolTip1.SetToolTip(checkBoxMDBBillAutoAccept, "Automatic accept escrowed bill for faster operation.");
            toolTip1.SetToolTip(buttonClearBillAmount, "Clear amount records.");

            // watchdog
            toolTip1.SetToolTip(buttonFeedWatchDog, "Keep WatchDog alive.");
            toolTip1.SetToolTip(buttonSetWatchDog, "Set timer intervals. All zeros to stop WatchDog function.");
            toolTip1.SetToolTip(numericUpDownWatchDogExpire, "Max time interval (in seconds) between each 'feeding'.");
            toolTip1.SetToolTip(numericUpDownWatchDogReboot, "Temporary suspend timer (in seconds) for PC to reboot.");
            toolTip1.SetToolTip(numericUpDownWatchDogReset, "Reset PC, relay hold time (in seconds).");

        }

        private void timerAutoPoll_Tick(object sender, EventArgs e)
        {
            if (checkBoxAutoBill.Checked == true)
            {
                if ((checkBoxAutoCoin.Checked == false) || (autoPollSeq == 0))
                {
                    buttonGetMDBBillStatus_Click(sender, e);
                }
            }
            if (checkBoxAutoCoin.Checked == true)
            {
                if ((checkBoxAutoBill.Checked == false) || (autoPollSeq == 1))
                {
                    buttonGetMDBCoinStatus_Click(sender, e);
                }
            }
            autoPollSeq++;
            if (autoPollSeq == 2) autoPollSeq = 0;


            pollRateChange++;
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            labelDLLVer.Text = SR1.GetDLLVer();
        }

        private void buttonOpenCOM_Click(object sender, EventArgs e)
        {
            int port;
            if (Int32.TryParse(textBoxCOMPort.Text, out port))           // allow integer only
            {
                int result = SR1.ConnectIPC(port);
                labelRtnOpenCOM.Text = Convert.ToString(result);
            }
            else
            {
                labelRtnOpenCOM.Text = "Invalid";
            }
            firstBillPoll = true;
            firstCoinPoll = true;
        }

        private void buttonCloseCOM_Click(object sender, EventArgs e)
        {
            int result = SR1.DisconnectIPC();
            labelRtnCloseCOM.Text = Convert.ToString(result);
        }

        private void buttonGetKernelVersion_Click(object sender, EventArgs e)
        {
            string myString = null;
            // clear previous display
            labelGetKernelVersionString.Text = "";
            int result = SR1.getKernelVer(ref myString);
            labelRtnGetKernelVersion.Text = Convert.ToString(result);
            if (result == 0) labelGetKernelVersionString.Text = myString;
        }

// IPC section
        private void buttonPingIPC_Click(object sender, EventArgs e)
        {
            int result = SR1.pingIPC();
            labelRtnPingIPC.Text = Convert.ToString(result);
        }

        private void buttonGetSerialNumber_Click(object sender, EventArgs e)
        {
            string myString = null;
            // clear previous display
            labelGetSerialNumberString.Text = "";
            int result = SR1.getSerialNumber(ref myString);
            labelRtnGetSerialNumber.Text = Convert.ToString(result);
            if (result == 0) labelGetSerialNumberString.Text = myString;
        }

// MDB section
        private void buttonResetMDB_Click(object sender, EventArgs e)
        {
            labelMDBBillCondition.Text = "Resetting";
            lastBillEventCounter = 0;
            lastCoinEventCounter = 0;
            int result = SR1.resetMDB();
            labelRtnResetMDB.Text = Convert.ToString(result);
        }

        private void DecodeCoinStatus(byte[] RxByte, int RxSize)
        {
            string stringCondition = "Online";
            // first byte is the Event Counter
            if ((RxByte[0] == lastCoinEventCounter) || (RxByte[0] == 0)) return;  // no change or IPC powered up
            // new events happened
            // turn off light boxes
            labelCoinStatusLightBox_Idle.BackColor = Color.Gray;
            labelCoinStatusLightBox_Reset.BackColor = Color.Gray;
            labelCoinStatusLightBox_Disabled.BackColor = Color.Gray;
            labelCoinStatusLightBox_Cheated.BackColor = Color.Gray;
            labelCoinStatusLightBox_Credit.BackColor = Color.Gray;
            labelCoinStatusLightBox_CreditAmount.BackColor = Color.Gray;
            labelCoinStatusLightBox_Credit2CB.BackColor = Color.Gray;
            labelCoinStatusLightBox_Credit2TU.BackColor = Color.Gray;
            labelCoinStatusLightBox_Credit2RJ.BackColor = Color.Gray;
            labelCoinStatusLightBox_Jammed.BackColor = Color.Gray;
            labelCoinStatusLightBox_Failure.BackColor = Color.Gray;
            labelCoinStatusLightBox_NoComm.BackColor = Color.Gray;
            labelCoinStatusLightBox_Manual.BackColor = Color.Gray;
            labelCoinStatusLightBox_ManualAmount.BackColor = Color.Gray;
            labelCoinStatusLightBox_EscrowLever.BackColor = Color.Gray;
            // Event counter starts at 0 on IPC power up
            // It overflows after 0xFF to 0x01 (skipping 0)
            int loop;
            if (RxByte[0] > lastCoinEventCounter)
            {
                loop = RxByte[0] - lastCoinEventCounter;
            }
            else
            {
                loop = (RxByte[0] - 1) + (256 - lastCoinEventCounter);
            }
            // update counter
            lastCoinEventCounter = RxByte[0];
            // only 20 events in replied message
            // limit loop to 20 if event count is larger than this
            // user should poll more often to prevent event overrun
            if (loop > 20) loop = 20;
            while (loop > 0)
            {
                switch (RxByte[loop])
                {
                    case 0x10:
                        // idling
                        labelCoinStatusLightBox_Idle.BackColor = Color.Yellow;
                        break;
                    case 0x11:
                        // device just reset
                        labelCoinStatusLightBox_Reset.BackColor = Color.Yellow;
                        break;
                    case 0x13:
                        // device disabled
                        labelCoinStatusLightBox_Disabled.BackColor = Color.Yellow;
                        break;
                    case 0x14:
                        // escrow request (lever activated)
                        labelCoinStatusLightBox_EscrowLever.BackColor = Color.Yellow;
                        break;
                    case 0x15:
                        // possible cheated
                        labelCoinStatusLightBox_Cheated.BackColor = Color.Yellow;
                        break;
                    case 0x16:
                        // coin deposited to cashbox
                        labelCoinStatusLightBox_Credit2CB.BackColor = Color.Yellow;
                        break;
                    case 0x17:
                        // coin deposited to tube
                        labelCoinStatusLightBox_Credit2TU.BackColor = Color.Yellow;
                        break;
                    case 0x19:
                        // coin deposited to reject
                        labelCoinStatusLightBox_Credit2RJ.BackColor = Color.Yellow;
                        break;
                    case 0x1A:
                        // jammed
                        labelCoinStatusLightBox_Jammed.BackColor = Color.Yellow;
                        break;
                    case 0x1D:
                        // peripheral failure
                        labelCoinStatusLightBox_Failure.BackColor = Color.Yellow;
                        break;
                    case 0x1F:
                        // no communication to device
                        labelCoinStatusLightBox_NoComm.BackColor = Color.Yellow;
                        stringCondition = "Offline";
                        break;
                    case 0x80:
                        // MDB controller suspended due to no comm from PC
                        stringCondition = "Stopped";
                        break;
                    case 0x81:
                        // MDB controller resumed
                        stringCondition = "Resumed";
                        break;
                }
                labelMDBCoinCondition.Text = stringCondition;
                
                // credit accepted
                if ((RxByte[loop] > 0x1F) && (RxByte[loop] < 0x30))
                {
                    labelCoinStatusLightBox_Credit.BackColor = Color.Yellow;
                    labelCoinStatusLightBox_CreditAmount.BackColor = Color.Yellow;
                    //
                    if (labelCoinScale.Text == "0")
                    {
                        // no Device Setup Info
                        labelCoinStatusLightBox_CreditAmount.Text = "???";
                    }
                    else
                    {
                        if (labelCoinStatusLightBox_CreditAmount.Text == "???")
                        {
                            labelCoinStatusLightBox_CreditAmount.Text = "0";
                        }
                        float faceValue = 0;
                        // retrieve coin value from channel number
                        switch (RxByte[loop])
                        {
                            case 0x20:
                                if (labelCoinCh0.Text != "Token") faceValue = Convert.ToSingle(labelCoinCh0.Text);
                                break;
                            case 0x21:
                                if (labelCoinCh1.Text != "Token") faceValue = Convert.ToSingle(labelCoinCh1.Text);
                                break;
                            case 0x22:
                                if (labelCoinCh2.Text != "Token") faceValue = Convert.ToSingle(labelCoinCh2.Text);
                                break;
                            case 0x23:
                                if (labelCoinCh3.Text != "Token") faceValue = Convert.ToSingle(labelCoinCh3.Text);
                                break;
                            case 0x24:
                                if (labelCoinCh4.Text != "Token") faceValue = Convert.ToSingle(labelCoinCh4.Text);
                                break;
                            case 0x25:
                                if (labelCoinCh5.Text != "Token") faceValue = Convert.ToSingle(labelCoinCh5.Text);
                                break;
                            case 0x26:
                                if (labelCoinCh6.Text != "Token") faceValue = Convert.ToSingle(labelCoinCh6.Text);
                                break;
                            case 0x27:
                                if (labelCoinCh7.Text != "Token") faceValue = Convert.ToSingle(labelCoinCh7.Text);
                                break;
                            case 0x28:
                                if (labelCoinCh8.Text != "Token") faceValue = Convert.ToSingle(labelCoinCh8.Text);
                                break;
                            case 0x29:
                                if (labelCoinCh9.Text != "Token") faceValue = Convert.ToSingle(labelCoinCh9.Text);
                                break;
                            case 0x2A:
                                if (labelCoinCh10.Text != "Token") faceValue = Convert.ToSingle(labelCoinCh10.Text);
                                break;
                            case 0x2B:
                                if (labelCoinCh11.Text != "Token") faceValue = Convert.ToSingle(labelCoinCh11.Text);
                                break;
                            case 0x2C:
                                if (labelCoinCh12.Text != "Token") faceValue = Convert.ToSingle(labelCoinCh12.Text);
                                break;
                            case 0x2D:
                                if (labelCoinCh13.Text != "Token") faceValue = Convert.ToSingle(labelCoinCh13.Text);
                                break;
                            case 0x2E:
                                if (labelCoinCh14.Text != "Token") faceValue = Convert.ToSingle(labelCoinCh14.Text);
                                break;
                            case 0x2F:
                                if (labelCoinCh15.Text != "Token") faceValue = Convert.ToSingle(labelCoinCh15.Text);
                                break;
                        }
                        float totalAmount = faceValue + Convert.ToSingle(labelCoinStatusLightBox_CreditAmount.Text);
                        labelCoinStatusLightBox_CreditAmount.Text = Convert.ToString(totalAmount);
                    }
                }
                // dispensed manually
                if ((RxByte[loop] > 0x2F) && (RxByte[loop] < 0x40))
                {
                    labelCoinStatusLightBox_Manual.BackColor = Color.Yellow;
                    labelCoinStatusLightBox_ManualAmount.BackColor = Color.Yellow;
                    //
                    if (labelCoinScale.Text == "0")
                    {
                        // no Device Setup Info
                        labelCoinStatusLightBox_ManualAmount.Text = "???";
                    }
                    else
                    {
                        if (labelCoinStatusLightBox_ManualAmount.Text == "???")
                        {
                            labelCoinStatusLightBox_ManualAmount.Text = "0";
                        }
                        float faceValue = 0;
                        // retrieve coin value from channel number
                        switch (RxByte[loop])
                        {
                            case 0x30:
                                if (labelCoinCh0.Text != "Token") faceValue = Convert.ToSingle(labelCoinCh0.Text);
                                break;
                            case 0x31:
                                if (labelCoinCh1.Text != "Token") faceValue = Convert.ToSingle(labelCoinCh1.Text);
                                break;
                            case 0x32:
                                if (labelCoinCh2.Text != "Token") faceValue = Convert.ToSingle(labelCoinCh2.Text);
                                break;
                            case 0x33:
                                if (labelCoinCh3.Text != "Token") faceValue = Convert.ToSingle(labelCoinCh3.Text);
                                break;
                            case 0x34:
                                if (labelCoinCh4.Text != "Token") faceValue = Convert.ToSingle(labelCoinCh4.Text);
                                break;
                            case 0x35:
                                if (labelCoinCh5.Text != "Token") faceValue = Convert.ToSingle(labelCoinCh5.Text);
                                break;
                            case 0x36:
                                if (labelCoinCh6.Text != "Token") faceValue = Convert.ToSingle(labelCoinCh6.Text);
                                break;
                            case 0x37:
                                if (labelCoinCh7.Text != "Token") faceValue = Convert.ToSingle(labelCoinCh7.Text);
                                break;
                            case 0x38:
                                if (labelCoinCh8.Text != "Token") faceValue = Convert.ToSingle(labelCoinCh8.Text);
                                break;
                            case 0x39:
                                if (labelCoinCh9.Text != "Token") faceValue = Convert.ToSingle(labelCoinCh9.Text);
                                break;
                            case 0x3A:
                                if (labelCoinCh10.Text != "Token") faceValue = Convert.ToSingle(labelCoinCh10.Text);
                                break;
                            case 0x3B:
                                if (labelCoinCh11.Text != "Token") faceValue = Convert.ToSingle(labelCoinCh11.Text);
                                break;
                            case 0x3C:
                                if (labelCoinCh12.Text != "Token") faceValue = Convert.ToSingle(labelCoinCh12.Text);
                                break;
                            case 0x3D:
                                if (labelCoinCh13.Text != "Token") faceValue = Convert.ToSingle(labelCoinCh13.Text);
                                break;
                            case 0x3E:
                                if (labelCoinCh14.Text != "Token") faceValue = Convert.ToSingle(labelCoinCh14.Text);
                                break;
                            case 0x3F:
                                if (labelCoinCh15.Text != "Token") faceValue = Convert.ToSingle(labelCoinCh15.Text);
                                break;
                        }
                        float totalAmount = faceValue + Convert.ToSingle(labelCoinStatusLightBox_ManualAmount.Text);
                        labelCoinStatusLightBox_ManualAmount.Text = Convert.ToString(totalAmount);
                    }
                }
                loop--;
            }
        }

        private void DecodeBillStatus(byte[] RxByte, int RxSize)
        {
            string stringCondition = "Online";

            byte temp0 = RxByte[0];
            byte temp1 = RxByte[1];
            byte temp2 = RxByte[2];
            byte temp3 = RxByte[3];
            byte temp4 = RxByte[4];
            byte temp5 = RxByte[5];
            byte temp6 = RxByte[6];
            byte temp7 = RxByte[7];
            byte temp8 = RxByte[8];
            byte temp9 = RxByte[9];
            byte temp10 = RxByte[10];
            byte temp11 = RxByte[11];
            byte temp12 = RxByte[12];
            byte temp13 = (byte)lastBillEventCounter;
            
            // first byte is the Event Counter
            if ((RxByte[0] == lastBillEventCounter) || (RxByte[0] == 0)) return;  // no change or IPC powered up
            // new events happened
            // turn off light boxes
            labelBillStatusLightBox_Idle.BackColor = Color.Gray;
            labelBillStatusLightBox_Reset.BackColor = Color.Gray;
            labelBillStatusLightBox_Disabled.BackColor = Color.Gray;
            labelBillStatusLightBox_Cheated.BackColor = Color.Gray;
            labelBillStatusLightBox_Credit.BackColor = Color.Gray;
            labelBillStatusLightBox_CreditAmount.BackColor = Color.Gray;
            labelBillStatusLightBox_Credit2CB.BackColor = Color.Gray;
            labelBillStatusLightBox_Credit2RE.BackColor = Color.Gray;
            labelBillStatusLightBox_Jammed.BackColor = Color.Gray;
            labelBillStatusLightBox_Failure.BackColor = Color.Gray;
            labelBillStatusLightBox_NoComm.BackColor = Color.Gray;
            labelBillStatusLightBox_ManualDispensed.BackColor = Color.Gray;
            labelBillStatusLightBox_ManualDispensedAmount.BackColor = Color.Gray;
            labelBillStatusLightBox_ManualFilled.BackColor = Color.Gray;
            labelBillStatusLightBox_ManualFilledAmount.BackColor = Color.Gray;
            labelBillStatusLightBox_InvalidEscrow.BackColor = Color.Gray;
            labelBillStatusLightBox_Rejected.BackColor = Color.Gray;
            labelBillStatusLightBox_Rejecting.BackColor = Color.Gray;
            labelBillStatusLightBox_Stacking.BackColor = Color.Gray;
            labelBillStatusLightBox_CassetteProblem.BackColor = Color.Gray;
            labelBillStatusLightBox_Escrowed.BackColor = Color.Gray;
            labelBillStatusLightBox_EscrowedAmount.BackColor = Color.Gray;
            labelBillStatusLightBox_Transferred.BackColor = Color.Gray;
            labelBillStatusLightBox_TransferredAmount.BackColor = Color.Gray;
            labelBillStatusLightBox_EscrowButton.BackColor = Color.Gray;
            labelBillStatusLightBox_FillButton.BackColor = Color.Gray;
            labelBillStatusLightBox_RecyclerDisabled.BackColor = Color.Gray;
            labelMDBBillCondition.Text = "";
            // Event counter starts at 0 on IPC power up
            // It overflows after 0xFF to 0x01 (skipping 0)
            int loop;
            if (RxByte[0] > lastBillEventCounter)
            {
                loop = RxByte[0] - lastBillEventCounter;
            }
            else
            {
                loop = (RxByte[0] - 1) + (256 - lastBillEventCounter);
            }
            // update counter
            lastBillEventCounter = RxByte[0];
            // only 20 events in replied message
            // limit loop to 20 if event counter is larger than this
            // user should poll more often to prevent event overrun
            if (loop > 20) loop = 20;
            while (loop > 0)
            {
                switch (RxByte[loop])
                {
                    case 0x10:
                        // idling
                        labelBillStatusLightBox_Idle.BackColor = Color.Yellow;
                        break;
                    case 0x11:
                        // device just reset
                        labelBillStatusLightBox_Reset.BackColor = Color.Yellow;
                        break;
                    case 0x13:
                        // device disabled
                        labelBillStatusLightBox_Disabled.BackColor = Color.Yellow;
                        break;
                    case 0x14:
                        // bill rejected
                        labelBillStatusLightBox_Rejected.BackColor = Color.Yellow;
                        break;
                    case 0x15:
                        // possible cheated
                        labelBillStatusLightBox_Cheated.BackColor = Color.Yellow;
                        break;
                    case 0x16:
                        // bill stacking
                        labelBillStatusLightBox_Stacking.BackColor = Color.Yellow;
                        break;
                    case 0x17:
                        // bill rejecting
                        labelBillStatusLightBox_Rejecting.BackColor = Color.Yellow;
                        break;
                    case 0x1A:
                        // jammed
                        labelBillStatusLightBox_Jammed.BackColor = Color.Yellow;
                        break;
                    case 0x1B:
                        // cassette problem
                        labelBillStatusLightBox_CassetteProblem.BackColor = Color.Yellow;
                        break;
                    case 0x1D:
                        // peripheral failure
                        labelBillStatusLightBox_Failure.BackColor = Color.Yellow;
                        break;
                    case 0x1E:
                        // invalid escrow command
                        labelBillStatusLightBox_InvalidEscrow.BackColor = Color.Yellow;
                        break;
                    case 0x1F:
                        // no communication to device
                        labelBillStatusLightBox_NoComm.BackColor = Color.Yellow;
                        stringCondition = "Offline";
                        break;
                    case 0x40:
                        // escrow request lever or button pressed
                        labelBillStatusLightBox_EscrowButton.BackColor = Color.Yellow;
                        break;
                    case 0x41:
                        // recycler disabled
                        labelBillStatusLightBox_RecyclerDisabled.BackColor = Color.Yellow;
                        break;
                    case 0x43:
                        // manual fill button pressed
                        labelBillStatusLightBox_FillButton.BackColor = Color.Yellow;
                        break;
                    case 0x80:
                        // MDB controller suspended due to no comm from PC
                        stringCondition = "Stopped";
                        break;
                    case 0x81:
                        // MDB controller resumed
                        stringCondition = "Resumed";
                        break;

                }
                labelMDBBillCondition.Text = stringCondition;

                // bill accepted to Cashbox or Recycler
                if (((RxByte[loop] > 0x1F) && (RxByte[loop] < 0x30)) ||
                    ((RxByte[loop] > 0x4F) && (RxByte[loop] < 0x60)))
                {
                    labelBillStatusLightBox_Credit.BackColor = Color.Yellow;
                    labelBillStatusLightBox_CreditAmount.BackColor = Color.Yellow;
                    //
                    if (labelBillScale.Text == "0")
                    {
                        // no Device Setup Info
                        labelBillStatusLightBox_CreditAmount.Text = "???";
                    }
                    else
                    {
                        if (labelBillStatusLightBox_CreditAmount.Text == "???")
                        {
                            labelBillStatusLightBox_CreditAmount.Text = "0";
                        }
                        float faceValue = 0;
                        // retrieve bill value from channel number
                        switch (RxByte[loop])
                        {
                            case 0x20:
                            case 0x50:
                                if (labelBillCh0.Text != "Token") faceValue = Convert.ToSingle(labelBillCh0.Text);
                                break;
                            case 0x21:
                            case 0x51:
                                if (labelBillCh1.Text != "Token") faceValue = Convert.ToSingle(labelBillCh1.Text);
                                break;
                            case 0x22:
                            case 0x52:
                                if (labelBillCh2.Text != "Token") faceValue = Convert.ToSingle(labelBillCh2.Text);
                                break;
                            case 0x23:
                            case 0x53:
                                if (labelBillCh3.Text != "Token") faceValue = Convert.ToSingle(labelBillCh3.Text);
                                break;
                            case 0x24:
                            case 0x54:
                                if (labelBillCh4.Text != "Token") faceValue = Convert.ToSingle(labelBillCh4.Text);
                                break;
                            case 0x25:
                            case 0x55:
                                if (labelBillCh5.Text != "Token") faceValue = Convert.ToSingle(labelBillCh5.Text);
                                break;
                            case 0x26:
                            case 0x56:
                                if (labelBillCh6.Text != "Token") faceValue = Convert.ToSingle(labelBillCh6.Text);
                                break;
                            case 0x27:
                            case 0x57:
                                if (labelBillCh7.Text != "Token") faceValue = Convert.ToSingle(labelBillCh7.Text);
                                break;
                            case 0x28:
                            case 0x58:
                                if (labelBillCh8.Text != "Token") faceValue = Convert.ToSingle(labelBillCh8.Text);
                                break;
                            case 0x29:
                            case 0x59:
                                if (labelBillCh9.Text != "Token") faceValue = Convert.ToSingle(labelBillCh9.Text);
                                break;
                            case 0x2A:
                            case 0x5A:
                                if (labelBillCh10.Text != "Token") faceValue = Convert.ToSingle(labelBillCh10.Text);
                                break;
                            case 0x2B:
                            case 0x5B:
                                if (labelBillCh11.Text != "Token") faceValue = Convert.ToSingle(labelBillCh11.Text);
                                break;
                            case 0x2C:
                            case 0x5C:
                                if (labelBillCh12.Text != "Token") faceValue = Convert.ToSingle(labelBillCh12.Text);
                                break;
                            case 0x2D:
                            case 0x5D:
                                if (labelBillCh13.Text != "Token") faceValue = Convert.ToSingle(labelBillCh13.Text);
                                break;
                            case 0x2E:
                            case 0x5E:
                                if (labelBillCh14.Text != "Token") faceValue = Convert.ToSingle(labelBillCh14.Text);
                                break;
                            case 0x2F:
                            case 0x5F:
                                if (labelBillCh15.Text != "Token") faceValue = Convert.ToSingle(labelBillCh15.Text);
                                break;
                        }
                        float totalAmount = faceValue + Convert.ToSingle(labelBillStatusLightBox_CreditAmount.Text);
                        labelBillStatusLightBox_CreditAmount.Text = Convert.ToString(totalAmount);

                    }
                    // show CB or RE
                    if (RxByte[loop] < 0x50)
                    {
                        labelBillStatusLightBox_Credit2CB.BackColor = Color.Yellow;
                    }
                    else
                    {
                        labelBillStatusLightBox_Credit2RE.BackColor = Color.Yellow;
                    }
                }
                // bill in Escrow
                if ((RxByte[loop] > 0x2F) && (RxByte[loop] < 0x40))
                {
                    // auto accept?
                    if (checkBoxMDBBillAutoAccept.Checked == true)
                    {
                        buttonMDBBillEscrowAccept.PerformClick();
                    }
                    else
                    {
                        labelBillStatusLightBox_Escrowed.BackColor = Color.Yellow;
                        labelBillStatusLightBox_EscrowedAmount.BackColor = Color.Yellow;
                        // highlight Escrow Accept and Escrow Return button for user input
                        buttonMDBBillEscrowAccept.BackColor = Color.Green;
                        buttonMDBBillEscrowReturn.BackColor = Color.Red;
                        //
                        if (labelBillScale.Text == "0")
                        {
                            // no Device Setup Info
                            labelBillStatusLightBox_EscrowedAmount.Text = "???";
                        }
                        else
                        {
                            if (labelBillStatusLightBox_EscrowedAmount.Text == "???")
                            {
                                labelBillStatusLightBox_EscrowedAmount.Text = "0";
                            }
                            float faceValue = 0;
                            // retrieve bill value from channel number
                            switch (RxByte[loop])
                            {
                                case 0x30:
                                    if (labelBillCh0.Text != "Token") faceValue = Convert.ToSingle(labelBillCh0.Text);
                                    break;
                                case 0x31:
                                    if (labelBillCh1.Text != "Token") faceValue = Convert.ToSingle(labelBillCh1.Text);
                                    break;
                                case 0x32:
                                    if (labelBillCh2.Text != "Token") faceValue = Convert.ToSingle(labelBillCh2.Text);
                                    break;
                                case 0x33:
                                    if (labelBillCh3.Text != "Token") faceValue = Convert.ToSingle(labelBillCh3.Text);
                                    break;
                                case 0x34:
                                    if (labelBillCh4.Text != "Token") faceValue = Convert.ToSingle(labelBillCh4.Text);
                                    break;
                                case 0x35:
                                    if (labelBillCh5.Text != "Token") faceValue = Convert.ToSingle(labelBillCh5.Text);
                                    break;
                                case 0x36:
                                    if (labelBillCh6.Text != "Token") faceValue = Convert.ToSingle(labelBillCh6.Text);
                                    break;
                                case 0x37:
                                    if (labelBillCh7.Text != "Token") faceValue = Convert.ToSingle(labelBillCh7.Text);
                                    break;
                                case 0x38:
                                    if (labelBillCh8.Text != "Token") faceValue = Convert.ToSingle(labelBillCh8.Text);
                                    break;
                                case 0x39:
                                    if (labelBillCh9.Text != "Token") faceValue = Convert.ToSingle(labelBillCh9.Text);
                                    break;
                                case 0x3A:
                                    if (labelBillCh10.Text != "Token") faceValue = Convert.ToSingle(labelBillCh10.Text);
                                    break;
                                case 0x3B:
                                    if (labelBillCh11.Text != "Token") faceValue = Convert.ToSingle(labelBillCh11.Text);
                                    break;
                                case 0x3C:
                                    if (labelBillCh12.Text != "Token") faceValue = Convert.ToSingle(labelBillCh12.Text);
                                    break;
                                case 0x3D:
                                    if (labelBillCh13.Text != "Token") faceValue = Convert.ToSingle(labelBillCh13.Text);
                                    break;
                                case 0x3E:
                                    if (labelBillCh14.Text != "Token") faceValue = Convert.ToSingle(labelBillCh14.Text);
                                    break;
                                case 0x3F:
                                    if (labelBillCh15.Text != "Token") faceValue = Convert.ToSingle(labelBillCh15.Text);
                                    break;
                            }
                            float totalAmount = faceValue + Convert.ToSingle(labelBillStatusLightBox_EscrowedAmount.Text);
                            labelBillStatusLightBox_EscrowedAmount.Text = Convert.ToString(totalAmount);
                        }
                    }
                }
                // transferred from RE to CB
                if ((RxByte[loop] > 0x6F) && (RxByte[loop] < 0x80))
                {
                    labelBillStatusLightBox_Transferred.BackColor = Color.Yellow;
                    labelBillStatusLightBox_TransferredAmount.BackColor = Color.Yellow;
                    if (labelBillScale.Text == "0")
                    {
                        // no Device Setup Info
                        labelBillStatusLightBox_TransferredAmount.Text = "???";
                    }
                    else
                    {
                        if (labelBillStatusLightBox_TransferredAmount.Text == "???")
                        {
                            labelBillStatusLightBox_TransferredAmount.Text = "0";
                        }
                        float faceValue = 0;
                        // retrieve bill value from channel number
                        switch (RxByte[loop])
                        {
                            case 0x70:
                                if (labelBillCh0.Text != "Token") faceValue = Convert.ToSingle(labelBillCh0.Text);
                                break;
                            case 0x71:
                                if (labelBillCh1.Text != "Token") faceValue = Convert.ToSingle(labelBillCh1.Text);
                                break;
                            case 0x72:
                                if (labelBillCh2.Text != "Token") faceValue = Convert.ToSingle(labelBillCh2.Text);
                                break;
                            case 0x73:
                                if (labelBillCh3.Text != "Token") faceValue = Convert.ToSingle(labelBillCh3.Text);
                                break;
                            case 0x74:
                                if (labelBillCh4.Text != "Token") faceValue = Convert.ToSingle(labelBillCh4.Text);
                                break;
                            case 0x75:
                                if (labelBillCh5.Text != "Token") faceValue = Convert.ToSingle(labelBillCh5.Text);
                                break;
                            case 0x76:
                                if (labelBillCh6.Text != "Token") faceValue = Convert.ToSingle(labelBillCh6.Text);
                                break;
                            case 0x77:
                                if (labelBillCh7.Text != "Token") faceValue = Convert.ToSingle(labelBillCh7.Text);
                                break;
                            case 0x78:
                                if (labelBillCh8.Text != "Token") faceValue = Convert.ToSingle(labelBillCh8.Text);
                                break;
                            case 0x79:
                                if (labelBillCh9.Text != "Token") faceValue = Convert.ToSingle(labelBillCh9.Text);
                                break;
                            case 0x7A:
                                if (labelBillCh10.Text != "Token") faceValue = Convert.ToSingle(labelBillCh10.Text);
                                break;
                            case 0x7B:
                                if (labelBillCh11.Text != "Token") faceValue = Convert.ToSingle(labelBillCh11.Text);
                                break;
                            case 0x7C:
                                if (labelBillCh12.Text != "Token") faceValue = Convert.ToSingle(labelBillCh12.Text);
                                break;
                            case 0x7D:
                                if (labelBillCh13.Text != "Token") faceValue = Convert.ToSingle(labelBillCh13.Text);
                                break;
                            case 0x7E:
                                if (labelBillCh14.Text != "Token") faceValue = Convert.ToSingle(labelBillCh14.Text);
                                break;
                            case 0x7F:
                                if (labelBillCh15.Text != "Token") faceValue = Convert.ToSingle(labelBillCh15.Text);
                                break;
                        }
                        float totalAmount = faceValue + Convert.ToSingle(labelBillStatusLightBox_TransferredAmount.Text);
                        labelBillStatusLightBox_TransferredAmount.Text = Convert.ToString(totalAmount);
                    }
                }
                // manual dispensed
                if ((RxByte[loop] > 0x9F) && (RxByte[loop] < 0xB0))
                {
                    labelBillStatusLightBox_ManualDispensed.BackColor = Color.Yellow;
                    labelBillStatusLightBox_ManualDispensedAmount.BackColor = Color.Yellow;
                    if (labelBillScale.Text == "0")
                    {
                        // no Device Setup Info
                        labelBillStatusLightBox_ManualDispensedAmount.Text = "???";
                    }
                    else
                    {
                        if (labelBillStatusLightBox_ManualDispensedAmount.Text == "???")
                        {
                            labelBillStatusLightBox_ManualDispensedAmount.Text = "0";
                        }
                        float faceValue = 0;
                        // retrieve bill value from channel number
                        switch (RxByte[loop])
                        {
                            case 0xA0:
                                if (labelBillCh0.Text != "Token") faceValue = Convert.ToSingle(labelBillCh0.Text);
                                break;
                            case 0xA1:
                                if (labelBillCh1.Text != "Token") faceValue = Convert.ToSingle(labelBillCh1.Text);
                                break;
                            case 0xA2:
                                if (labelBillCh2.Text != "Token") faceValue = Convert.ToSingle(labelBillCh2.Text);
                                break;
                            case 0xA3:
                                if (labelBillCh3.Text != "Token") faceValue = Convert.ToSingle(labelBillCh3.Text);
                                break;
                            case 0xA4:
                                if (labelBillCh4.Text != "Token") faceValue = Convert.ToSingle(labelBillCh4.Text);
                                break;
                            case 0xA5:
                                if (labelBillCh5.Text != "Token") faceValue = Convert.ToSingle(labelBillCh5.Text);
                                break;
                            case 0xA6:
                                if (labelBillCh6.Text != "Token") faceValue = Convert.ToSingle(labelBillCh6.Text);
                                break;
                            case 0xA7:
                                if (labelBillCh7.Text != "Token") faceValue = Convert.ToSingle(labelBillCh7.Text);
                                break;
                            case 0xA8:
                                if (labelBillCh8.Text != "Token") faceValue = Convert.ToSingle(labelBillCh8.Text);
                                break;
                            case 0xA9:
                                if (labelBillCh9.Text != "Token") faceValue = Convert.ToSingle(labelBillCh9.Text);
                                break;
                            case 0xAA:
                                if (labelBillCh10.Text != "Token") faceValue = Convert.ToSingle(labelBillCh10.Text);
                                break;
                            case 0xAB:
                                if (labelBillCh11.Text != "Token") faceValue = Convert.ToSingle(labelBillCh11.Text);
                                break;
                            case 0xAC:
                                if (labelBillCh12.Text != "Token") faceValue = Convert.ToSingle(labelBillCh12.Text);
                                break;
                            case 0xAD:
                                if (labelBillCh13.Text != "Token") faceValue = Convert.ToSingle(labelBillCh13.Text);
                                break;
                            case 0xAE:
                                if (labelBillCh14.Text != "Token") faceValue = Convert.ToSingle(labelBillCh14.Text);
                                break;
                            case 0xAF:
                                if (labelBillCh15.Text != "Token") faceValue = Convert.ToSingle(labelBillCh15.Text);
                                break;
                        }
                        float totalAmount = faceValue + Convert.ToSingle(labelBillStatusLightBox_ManualDispensedAmount.Text);
                        labelBillStatusLightBox_ManualDispensedAmount.Text = Convert.ToString(totalAmount);
                    }
                }
                // manual filled
                if ((RxByte[loop] > 0x5F) && (RxByte[loop] < 0x70))
                {
                    labelBillStatusLightBox_ManualFilled.BackColor = Color.Yellow;
                    labelBillStatusLightBox_ManualFilledAmount.BackColor = Color.Yellow;
                    if (labelBillScale.Text == "0")
                    {
                        // no Device Setup Info
                        labelBillStatusLightBox_ManualFilledAmount.Text = "???";
                    }
                    else
                    {
                        if (labelBillStatusLightBox_ManualFilledAmount.Text == "???")
                        {
                            labelBillStatusLightBox_ManualFilledAmount.Text = "0";
                        }
                        float faceValue = 0;
                        // retrieve bill value from channel number
                        switch (RxByte[loop])
                        {
                            case 0x60:
                                if (labelBillCh0.Text != "Token") faceValue = Convert.ToSingle(labelBillCh0.Text);
                                break;
                            case 0x61:
                                if (labelBillCh1.Text != "Token") faceValue = Convert.ToSingle(labelBillCh1.Text);
                                break;
                            case 0x62:
                                if (labelBillCh2.Text != "Token") faceValue = Convert.ToSingle(labelBillCh2.Text);
                                break;
                            case 0x63:
                                if (labelBillCh3.Text != "Token") faceValue = Convert.ToSingle(labelBillCh3.Text);
                                break;
                            case 0x64:
                                if (labelBillCh4.Text != "Token") faceValue = Convert.ToSingle(labelBillCh4.Text);
                                break;
                            case 0x65:
                                if (labelBillCh5.Text != "Token") faceValue = Convert.ToSingle(labelBillCh5.Text);
                                break;
                            case 0x66:
                                if (labelBillCh6.Text != "Token") faceValue = Convert.ToSingle(labelBillCh6.Text);
                                break;
                            case 0x67:
                                if (labelBillCh7.Text != "Token") faceValue = Convert.ToSingle(labelBillCh7.Text);
                                break;
                            case 0x68:
                                if (labelBillCh8.Text != "Token") faceValue = Convert.ToSingle(labelBillCh8.Text);
                                break;
                            case 0x69:
                                if (labelBillCh9.Text != "Token") faceValue = Convert.ToSingle(labelBillCh9.Text);
                                break;
                            case 0x6A:
                                if (labelBillCh10.Text != "Token") faceValue = Convert.ToSingle(labelBillCh10.Text);
                                break;
                            case 0x6B:
                                if (labelBillCh11.Text != "Token") faceValue = Convert.ToSingle(labelBillCh11.Text);
                                break;
                            case 0x6C:
                                if (labelBillCh12.Text != "Token") faceValue = Convert.ToSingle(labelBillCh12.Text);
                                break;
                            case 0x6D:
                                if (labelBillCh13.Text != "Token") faceValue = Convert.ToSingle(labelBillCh13.Text);
                                break;
                            case 0x6E:
                                if (labelBillCh14.Text != "Token") faceValue = Convert.ToSingle(labelBillCh14.Text);
                                break;
                            case 0x6F:
                                if (labelBillCh15.Text != "Token") faceValue = Convert.ToSingle(labelBillCh15.Text);
                                break;
                        }
                        float totalAmount = faceValue + Convert.ToSingle(labelBillStatusLightBox_ManualFilledAmount.Text);
                        labelBillStatusLightBox_ManualFilledAmount.Text = Convert.ToString(totalAmount);
                    }
                }               
                loop--;
            }
        }

        private void buttonGetMDBBillStatus_Click(object sender, EventArgs e)
        {
            byte[] RxByte = new byte[1];            // array to hold receive data
            int RxSize = 0;
            // clear previous display
            labelGetMDBBillStatusString.Text = "";
            int result = SR1.getMDBBillStatus(ref RxByte, ref RxSize);
            labelRtnGetMDBBillStatus.Text = Convert.ToString(result);
            if (result == 0)
            {
                string displayString = null;
                for (int loop = 0; loop < RxSize; loop++)
                {
                    displayString += String.Format("{0,3:X}", RxByte[loop]);  // padding 3, display Hex value
                }
                labelGetMDBBillStatusString.Text = displayString;
                if (firstBillPoll == true)
                {
                    // do not decode old status if this is a fresh start
                    lastBillEventCounter = RxByte[0];
                }
                firstBillPoll = false;
                DecodeBillStatus(RxByte, RxSize);
            }
        }

        private void buttonGetMDBCoinStatus_Click(object sender, EventArgs e)
        {
            byte[] RxByte = new byte[1];            // array to hold receive data
            int RxSize = 0;
            // clear previous display
            labelGetMDBCoinStatusString.Text = "";
            int result = SR1.getMDBCoinStatus(ref RxByte, ref RxSize);
            labelRtnGetMDBCoinStatus.Text = Convert.ToString(result);
            if (result == 0)
            {
                string displayString = null;
                for (int loop = 0; loop < RxSize; loop++)
                {
                    displayString += String.Format("{0,3:X}", RxByte[loop]);  // padding 3, display Hex value
                }
                labelGetMDBCoinStatusString.Text = displayString;
                if (firstCoinPoll == true)
                {
                    // do not decode old status if this is a fresh start
                    lastCoinEventCounter = RxByte[0];
                }
                firstCoinPoll = false;
                DecodeCoinStatus(RxByte, RxSize);
            }
        }

        private void buttonSetMDBCoinChannels_Click(object sender, EventArgs e)
        {
            byte hiByte = 0;
            byte loByte = 0;
            if (checkBoxCoinEnable0.Checked) loByte = 1;
            if (checkBoxCoinEnable1.Checked) loByte += 2;
            if (checkBoxCoinEnable2.Checked) loByte += 4;
            if (checkBoxCoinEnable3.Checked) loByte += 8;
            if (checkBoxCoinEnable4.Checked) loByte += 16;
            if (checkBoxCoinEnable5.Checked) loByte += 32;
            if (checkBoxCoinEnable6.Checked) loByte += 64;
            if (checkBoxCoinEnable7.Checked) loByte += 128;
            if (checkBoxCoinEnable8.Checked) hiByte = 1;
            if (checkBoxCoinEnable9.Checked) hiByte += 2;
            if (checkBoxCoinEnable10.Checked) hiByte += 4;
            if (checkBoxCoinEnable11.Checked) hiByte += 8;
            if (checkBoxCoinEnable12.Checked) hiByte += 16;
            if (checkBoxCoinEnable13.Checked) hiByte += 32;
            if (checkBoxCoinEnable14.Checked) hiByte += 64;
            if (checkBoxCoinEnable15.Checked) hiByte += 128;
            int result = SR1.setMDBCoinEnable(hiByte, loByte);
            labelRtnSetMDBCoinChannels.Text = Convert.ToString(result);
        }

        private void buttonGetMDBCoinPayoutFinal_Click(object sender, EventArgs e)
        {
            byte[] RxByte = new byte[1];            // array to hold receive data
            int RxSize = 0;
            // clear previous display
            labelMiscMDBCmdRepliedString.Text = "";
            labelCoinPayoutFinal0.Text = "0";
            labelCoinPayoutFinal0.BackColor = Color.Gray;
            labelCoinPayoutFinal1.Text = "0";
            labelCoinPayoutFinal1.BackColor = Color.Gray;
            labelCoinPayoutFinal2.Text = "0";
            labelCoinPayoutFinal2.BackColor = Color.Gray;
            labelCoinPayoutFinal3.Text = "0";
            labelCoinPayoutFinal3.BackColor = Color.Gray;
            labelCoinPayoutFinal4.Text = "0";
            labelCoinPayoutFinal4.BackColor = Color.Gray;
            labelCoinPayoutFinal5.Text = "0";
            labelCoinPayoutFinal5.BackColor = Color.Gray;
            labelCoinPayoutFinal6.Text = "0";
            labelCoinPayoutFinal6.BackColor = Color.Gray;
            labelCoinPayoutFinal7.Text = "0";
            labelCoinPayoutFinal7.BackColor = Color.Gray;
            labelCoinPayoutFinal8.Text = "0";
            labelCoinPayoutFinal8.BackColor = Color.Gray;
            labelCoinPayoutFinal9.Text = "0";
            labelCoinPayoutFinal9.BackColor = Color.Gray;
            labelCoinPayoutFinal10.Text = "0";
            labelCoinPayoutFinal10.BackColor = Color.Gray;
            labelCoinPayoutFinal11.Text = "0";
            labelCoinPayoutFinal11.BackColor = Color.Gray;
            labelCoinPayoutFinal12.Text = "0";
            labelCoinPayoutFinal12.BackColor = Color.Gray;
            labelCoinPayoutFinal13.Text = "0";
            labelCoinPayoutFinal13.BackColor = Color.Gray;
            labelCoinPayoutFinal14.Text = "0";
            labelCoinPayoutFinal14.BackColor = Color.Gray;
            labelCoinPayoutFinal15.Text = "0";
            labelCoinPayoutFinal15.BackColor = Color.Gray;
            labelGetMDBCoinPayoutFinalAckOnly.Visible = false;

            int result = SR1.getMDBCoinPayoutFinal(ref RxByte, ref RxSize);
            labelRtnGetMDBCoinPayoutFinal.Text = Convert.ToString(result);
            if (result == 0)
            {
                string displayString = null;
                for (int loop = 0; loop < RxSize; loop++)
                {
                    displayString += String.Format("{0,3:X}", RxByte[loop]);  // padding 3, display Hex value
                }
                labelMiscMDBCmdRepliedString.Text = displayString;
                // make sure this message contains 16 bytes data
                if (RxSize > 15)
                {
                    // show new info
                    if (RxByte[0] > 0)
                    {
                        labelCoinPayoutFinal0.Text = String.Format("{0:D}", RxByte[0]);
                        labelCoinPayoutFinal0.BackColor = Color.Gold;
                    }
                    else
                    {
                        labelCoinPayoutFinal0.Text = "0";
                        labelCoinPayoutFinal0.BackColor = Color.Gray;
                    }
                    if (RxByte[1] > 0)
                    {
                        labelCoinPayoutFinal1.Text = String.Format("{0:D}", RxByte[1]);
                        labelCoinPayoutFinal1.BackColor = Color.Gold;
                    }
                    else
                    {
                        labelCoinPayoutFinal1.Text = "0";
                        labelCoinPayoutFinal1.BackColor = Color.Gray;
                    }
                    if (RxByte[2] > 0)
                    {
                        labelCoinPayoutFinal2.Text = String.Format("{0:D}", RxByte[2]);
                        labelCoinPayoutFinal2.BackColor = Color.Gold;
                    }
                    else
                    {
                        labelCoinPayoutFinal2.Text = "0";
                        labelCoinPayoutFinal2.BackColor = Color.Gray;
                    }
                    if (RxByte[3] > 0)
                    {
                        labelCoinPayoutFinal3.Text = String.Format("{0:D}", RxByte[3]);
                        labelCoinPayoutFinal3.BackColor = Color.Gold;
                    }
                    else
                    {
                        labelCoinPayoutFinal3.Text = "0";
                        labelCoinPayoutFinal3.BackColor = Color.Gray;
                    }
                    if (RxByte[4] > 0)
                    {
                        labelCoinPayoutFinal4.Text = String.Format("{0:D}", RxByte[4]);
                        labelCoinPayoutFinal4.BackColor = Color.Gold;
                    }
                    else
                    {
                        labelCoinPayoutFinal4.Text = "0";
                        labelCoinPayoutFinal4.BackColor = Color.Gray;
                    }
                    if (RxByte[5] > 0)
                    {
                        labelCoinPayoutFinal5.Text = String.Format("{0:D}", RxByte[5]);
                        labelCoinPayoutFinal5.BackColor = Color.Gold;
                    }
                    else
                    {
                        labelCoinPayoutFinal5.Text = "0";
                        labelCoinPayoutFinal5.BackColor = Color.Gray;
                    }
                    if (RxByte[6] > 0)
                    {
                        labelCoinPayoutFinal6.Text = String.Format("{0:D}", RxByte[6]);
                        labelCoinPayoutFinal6.BackColor = Color.Gold;
                    }
                    else
                    {
                        labelCoinPayoutFinal6.Text = "0";
                        labelCoinPayoutFinal6.BackColor = Color.Gray;
                    }
                    if (RxByte[7] > 0)
                    {
                        labelCoinPayoutFinal7.Text = String.Format("{0:D}", RxByte[7]);
                        labelCoinPayoutFinal7.BackColor = Color.Gold;
                    }
                    else
                    {
                        labelCoinPayoutFinal7.Text = "0";
                        labelCoinPayoutFinal7.BackColor = Color.Gray;
                    }
                    if (RxByte[8] > 0)
                    {
                        labelCoinPayoutFinal8.Text = String.Format("{0:D}", RxByte[8]);
                        labelCoinPayoutFinal8.BackColor = Color.Gold;
                    }
                    else
                    {
                        labelCoinPayoutFinal8.Text = "0";
                        labelCoinPayoutFinal8.BackColor = Color.Gray;
                    }
                    if (RxByte[9] > 0)
                    {
                        labelCoinPayoutFinal9.Text = String.Format("{0:D}", RxByte[9]);
                        labelCoinPayoutFinal9.BackColor = Color.Gold;
                    }
                    else
                    {
                        labelCoinPayoutFinal9.Text = "0";
                        labelCoinPayoutFinal9.BackColor = Color.Gray;
                    }
                    if (RxByte[10] > 0)
                    {
                        labelCoinPayoutFinal10.Text = String.Format("{0:D}", RxByte[10]);
                        labelCoinPayoutFinal10.BackColor = Color.Gold;
                    }
                    else
                    {
                        labelCoinPayoutFinal10.Text = "0";
                        labelCoinPayoutFinal10.BackColor = Color.Gray;
                    }
                    if (RxByte[11] > 0)
                    {
                        labelCoinPayoutFinal11.Text = String.Format("{0:D}", RxByte[11]);
                        labelCoinPayoutFinal11.BackColor = Color.Gold;
                    }
                    else
                    {
                        labelCoinPayoutFinal11.Text = "0";
                        labelCoinPayoutFinal11.BackColor = Color.Gray;
                    }
                    if (RxByte[12] > 0)
                    {
                        labelCoinPayoutFinal12.Text = String.Format("{0:D}", RxByte[12]);
                        labelCoinPayoutFinal12.BackColor = Color.Gold;
                    }
                    else
                    {
                        labelCoinPayoutFinal12.Text = "0";
                        labelCoinPayoutFinal12.BackColor = Color.Gray;
                    }
                    if (RxByte[13] > 0)
                    {
                        labelCoinPayoutFinal13.Text = String.Format("{0:D}", RxByte[13]);
                        labelCoinPayoutFinal13.BackColor = Color.Gold;
                    }
                    else
                    {
                        labelCoinPayoutFinal13.Text = "0";
                        labelCoinPayoutFinal13.BackColor = Color.Gray;
                    }
                    if (RxByte[14] > 0)
                    {
                        labelCoinPayoutFinal14.Text = String.Format("{0:D}", RxByte[14]);
                        labelCoinPayoutFinal14.BackColor = Color.Gold;
                    }
                    else
                    {
                        labelCoinPayoutFinal14.Text = "0";
                        labelCoinPayoutFinal14.BackColor = Color.Gray;
                    }
                    if (RxByte[15] > 0)
                    {
                        labelCoinPayoutFinal15.Text = String.Format("{0:D}", RxByte[15]);
                        labelCoinPayoutFinal15.BackColor = Color.Gold;
                    }
                    else
                    {
                        labelCoinPayoutFinal15.Text = "0";
                        labelCoinPayoutFinal15.BackColor = Color.Gray;
                    }
                }
                else
                {
                    labelGetMDBCoinPayoutFinalAckOnly.Visible = true;
                }

            }
        }

        private void buttonPollMDBCoinPayout_Click(object sender, EventArgs e)
        {
            byte[] RxByte = new byte[1];            // array to hold receive data
            int RxSize = 0;
            // clear previous display
            labelPollMDBCoinPayoutString.Text = "";
            int result = SR1.pollMDBCoinPayout(ref RxByte, ref RxSize);
            labelRtnPollMDBCoinPayout.Text = Convert.ToString(result);
            if (result == 0)
            {
                string displayString = null;
                if (RxSize == 0)
                {
                    displayString = "Ack";
                }
                else
                {
                    if (labelCoinScale.Text == "0")
                    {
                        displayString = "???";
                    }
                    else
                    {
                        displayString = ConvertToCurrencyString(RxByte[0], Convert.ToInt32(labelCoinScale.Text), Convert.ToByte(labelCoinDecimal.Text));
                    }
                }
                labelPollMDBCoinPayoutString.Text = displayString;
            }
        }

        private void buttonDispenseMDBCoinsByValue_Click(object sender, EventArgs e)
        {
            int result = 0;
            float floatValue = (float)numericUpDownDispenseMDBCoinsByValue.Value;
            // decimal got from Get Device Setup command
            int Y = Convert.ToInt32(labelCoinDecimal.Text);
            // scaling factor got from Get Device Setup command
            int Z = Convert.ToInt32(labelCoinScale.Text);
            // quit if Scaling factor = 0
            // run Get Device Setup first
            if (Z == 0)
            {
                result = 2;
            }
            else
            {
                // Amount * 10^Y / Z
                floatValue *= (float)Math.Pow(10, Y);
                int intValue = (int)floatValue / Z;
                // send out command for non-zero integer only
                if ((intValue > 0) && (floatValue % Z == 0))
                {
                    //value = Convert.ToByte(textBoxDispenseMDBCoinsByValue.Text);
                    result = SR1.dispenseMDBCoinsByValue((byte)intValue);
                }
                else
                {
                    result = 2;
                }
            }
            labelRtnDispenseMDBCoinsByValue.Text = Convert.ToString(result);
        }

        private string ConvertToCurrencyString(int Base, int Scale, byte Decimal)
        {
            int Amount = Base * Scale;
            string thisString = String.Format("{0:D}", Amount);
            int Points = (int)Decimal;
            int strLength = thisString.Length;

            // add leading 0s if string too short
            if (strLength < Points + 1)
            {
                while (Points + 1 - strLength > 0)
                {
                    thisString = "0" + thisString;
                    Points--;
                }
            }
            // update length
            strLength = thisString.Length;
            // add "." to the right location
            return thisString.Substring(0,strLength - Decimal) + "." + thisString.Substring(strLength-Decimal,Decimal);
        }

        private void buttonGetMDBCoinSetup_Click(object sender, EventArgs e)
        {
            byte[] RxByte = new byte[1];            // array to hold receive data
            int RxSize = 0;
            // clear previous display
            labelMiscMDBCmdRepliedString.Text = "";
            labelCoinLevel.Text = "0";
            labelCoinLevel.BackColor = Color.Gray;
            labelCoinISO.Text = "0";
            labelCoinISO.BackColor = Color.Gray;
            labelCoinScale.Text = "0";
            labelCoinScale.BackColor = Color.Gray;
            labelCoinDecimal.Text = "0";
            labelCoinDecimal.BackColor = Color.Gray;
            labelCoinCh0.Text = "0";
            labelCoinCh0.BackColor = Color.Gray;
            labelCoinCh1.Text = "0";
            labelCoinCh1.BackColor = Color.Gray;
            labelCoinCh2.Text = "0";
            labelCoinCh2.BackColor = Color.Gray;
            labelCoinCh3.Text = "0";
            labelCoinCh3.BackColor = Color.Gray;
            labelCoinCh4.Text = "0";
            labelCoinCh4.BackColor = Color.Gray;
            labelCoinCh5.Text = "0";
            labelCoinCh5.BackColor = Color.Gray;
            labelCoinCh6.Text = "0";
            labelCoinCh6.BackColor = Color.Gray;
            labelCoinCh7.Text = "0";
            labelCoinCh7.BackColor = Color.Gray;
            labelCoinCh8.Text = "0";
            labelCoinCh8.BackColor = Color.Gray;
            labelCoinCh9.Text = "0";
            labelCoinCh9.BackColor = Color.Gray;
            labelCoinCh10.Text = "0";
            labelCoinCh10.BackColor = Color.Gray;
            labelCoinCh11.Text = "0";
            labelCoinCh11.BackColor = Color.Gray;
            labelCoinCh12.Text = "0";
            labelCoinCh12.BackColor = Color.Gray;
            labelCoinCh13.Text = "0";
            labelCoinCh13.BackColor = Color.Gray;
            labelCoinCh14.Text = "0";
            labelCoinCh14.BackColor = Color.Gray;
            labelCoinCh15.Text = "0";
            labelCoinCh15.BackColor = Color.Gray;
            int result = SR1.getMDBCoinSetup(ref RxByte, ref RxSize);
            labelRtnGetMDBCoinSetup.Text = Convert.ToString(result);
            if (result == 0)
            {
                string displayString = null;
                for (int loop = 0; loop < RxSize; loop++)
                {
                    displayString += String.Format("{0,3:X}", RxByte[loop]);  // padding 3, display Hex value
                }
                labelMiscMDBCmdRepliedString.Text = displayString;
                // show info
                labelCoinLevel.Text = String.Format("{0:X}", RxByte[0]);
                labelCoinLevel.BackColor = Color.Gold;
                labelCoinISO.Text = String.Format("{0:X}", RxByte[1]) + String.Format("{0:X}", RxByte[2]);
                labelCoinISO.BackColor = Color.Gold;
                labelCoinScale.Text = String.Format("{0:D}", RxByte[3]);
                labelCoinScale.BackColor = Color.Gold;
                labelCoinDecimal.Text = String.Format("{0:D}", RxByte[4]);
                labelCoinDecimal.BackColor = Color.Gold;
                // set numeric controls for Dispense by Value
                numericUpDownDispenseMDBCoinsByValue.DecimalPlaces = RxByte[4];
                switch (RxByte[4])
                {
                    case 0:
                        numericUpDownDispenseMDBCoinsByValue.Increment = 1;
                        break;
                    case 1:
                        numericUpDownDispenseMDBCoinsByValue.Increment = (decimal)0.1;
                        break;
                    case 2:
                        numericUpDownDispenseMDBCoinsByValue.Increment = (decimal)0.01;
                        break;
                    case 3:
                        numericUpDownDispenseMDBCoinsByValue.Increment = (decimal)0.001;
                        break;
                    case 4:
                        numericUpDownDispenseMDBCoinsByValue.Increment = (decimal)0.0001;
                        break;
                }
                if (RxByte[7] > 0)
                {
                    labelCoinCh0.Text = ConvertToCurrencyString(RxByte[7], RxByte[3], RxByte[4]);
                    labelCoinCh0.BackColor = Color.Gold;
                }
                if (RxByte[8] > 0)
                {
                    labelCoinCh1.Text = ConvertToCurrencyString(RxByte[8], RxByte[3], RxByte[4]);
                    labelCoinCh1.BackColor = Color.Gold;
                }
                if (RxByte[9] > 0)
                {
                    labelCoinCh2.Text = ConvertToCurrencyString(RxByte[9], RxByte[3], RxByte[4]);
                    labelCoinCh2.BackColor = Color.Gold;
                }
                if (RxByte[10] > 0)
                {
                    labelCoinCh3.Text = ConvertToCurrencyString(RxByte[10], RxByte[3], RxByte[4]);
                    labelCoinCh3.BackColor = Color.Gold;
                }
                if (RxByte[11] > 0)
                {
                    labelCoinCh4.Text = ConvertToCurrencyString(RxByte[11], RxByte[3], RxByte[4]);
                    labelCoinCh4.BackColor = Color.Gold;
                }
                if (RxByte[12] > 0)
                {
                    labelCoinCh5.Text = ConvertToCurrencyString(RxByte[12], RxByte[3], RxByte[4]);
                    labelCoinCh5.BackColor = Color.Gold;
                }
                if (RxByte[13] > 0)
                {
                    labelCoinCh6.Text = ConvertToCurrencyString(RxByte[13], RxByte[3], RxByte[4]);
                    labelCoinCh6.BackColor = Color.Gold;
                }
                if (RxByte[14] > 0)
                {
                    labelCoinCh7.Text = ConvertToCurrencyString(RxByte[14], RxByte[3], RxByte[4]);
                    labelCoinCh7.BackColor = Color.Gold;
                }
                if (RxByte[15] > 0)
                {
                    labelCoinCh8.Text = ConvertToCurrencyString(RxByte[15], RxByte[3], RxByte[4]);
                    labelCoinCh8.BackColor = Color.Gold;
                }
                if (RxByte[16] > 0)
                {
                    labelCoinCh9.Text = ConvertToCurrencyString(RxByte[16], RxByte[3], RxByte[4]);
                    labelCoinCh9.BackColor = Color.Gold;
                }
                if (RxByte[17] > 0)
                {
                    labelCoinCh10.Text = ConvertToCurrencyString(RxByte[17], RxByte[3], RxByte[4]);
                    labelCoinCh10.BackColor = Color.Gold;
                }
                if (RxByte[18] > 0)
                {
                    labelCoinCh11.Text = ConvertToCurrencyString(RxByte[18], RxByte[3], RxByte[4]);
                    labelCoinCh11.BackColor = Color.Gold;
                }
                if (RxByte[19] > 0)
                {
                    labelCoinCh12.Text = ConvertToCurrencyString(RxByte[19], RxByte[3], RxByte[4]);
                    labelCoinCh12.BackColor = Color.Gold;
                }
                if (RxByte[20] > 0)
                {
                    labelCoinCh13.Text = ConvertToCurrencyString(RxByte[20], RxByte[3], RxByte[4]);
                    labelCoinCh13.BackColor = Color.Gold;
                }
                if (RxByte[21] > 0)
                {
                    labelCoinCh14.Text = ConvertToCurrencyString(RxByte[21], RxByte[3], RxByte[4]);
                    labelCoinCh14.BackColor = Color.Gold;
                }
                if (RxByte[22] > 0)
                {
                    labelCoinCh15.Text = ConvertToCurrencyString(RxByte[22], RxByte[3], RxByte[4]);
                    labelCoinCh15.BackColor = Color.Gold;
                }
            }
        }

        private void buttonGetMDBCoinTubeContent_Click(object sender, EventArgs e)
        {
            byte[] RxByte = new byte[1];            // array to hold receive data
            int RxSize = 0;
            // clear previous display
            labelMiscMDBCmdRepliedString.Text = "";
            labelTube0.Text = "0";
            labelTube0.BackColor = Color.Gray;
            labelTube1.Text = "0";
            labelTube1.BackColor = Color.Gray;
            labelTube2.Text = "0";
            labelTube2.BackColor = Color.Gray;
            labelTube3.Text = "0";
            labelTube3.BackColor = Color.Gray;
            labelTube4.Text = "0";
            labelTube4.BackColor = Color.Gray;
            labelTube5.Text = "0";
            labelTube5.BackColor = Color.Gray;
            labelTube6.Text = "0";
            labelTube6.BackColor = Color.Gray;
            labelTube7.Text = "0";
            labelTube7.BackColor = Color.Gray;
            labelTube8.Text = "0";
            labelTube8.BackColor = Color.Gray;
            labelTube9.Text = "0";
            labelTube9.BackColor = Color.Gray;
            labelTube10.Text = "0";
            labelTube10.BackColor = Color.Gray;
            labelTube11.Text = "0";
            labelTube11.BackColor = Color.Gray;
            labelTube12.Text = "0";
            labelTube12.BackColor = Color.Gray;
            labelTube13.Text = "0";
            labelTube13.BackColor = Color.Gray;
            labelTube14.Text = "0";
            labelTube14.BackColor = Color.Gray;
            labelTube15.Text = "0";
            labelTube15.BackColor = Color.Gray;
            int result = SR1.getMDBCoinTubeContent(ref RxByte, ref RxSize);
            labelRtnGetMDBCoinTubeContent.Text = Convert.ToString(result);
            if (result == 0)
            {
                string displayString = null;
                for (int loop = 0; loop < RxSize; loop++)
                {
                    displayString += String.Format("{0,3:X}", RxByte[loop]);  // padding 3, display Hex value
                }
                labelMiscMDBCmdRepliedString.Text = displayString;
                // show info
                if ((RxByte[1] & 0x01) > 0)
                {
                    if (RxByte[2] > 0)
                    {
                        labelTube0.Text = "Full";
                        labelTube0.BackColor = Color.Gold;
                    }
                    else
                    {
                        labelTube0.Text = "Jam";
                        labelTube0.BackColor = Color.Red;
                    }
                }
                else if (RxByte[2] > 0)
                {
                    labelTube0.Text = String.Format("{0:D}", RxByte[2]);
                    labelTube0.BackColor = Color.Gold;
                }
                if ((RxByte[1] & 0x02) > 0)
                {
                    if (RxByte[3] > 0)
                    {
                        labelTube1.Text = "Full";
                        labelTube1.BackColor = Color.Gold;
                    }
                    else
                    {
                        labelTube1.Text = "Jam";
                        labelTube1.BackColor = Color.Red;
                    }
                }
                else if (RxByte[3] > 0)
                {
                    labelTube1.Text = String.Format("{0:D}", RxByte[3]);
                    labelTube1.BackColor = Color.Gold;
                }
                if ((RxByte[1] & 0x04) > 0)
                {
                    if (RxByte[4] > 0)
                    {
                        labelTube2.Text = "Full";
                        labelTube2.BackColor = Color.Gold;
                    }
                    else
                    {
                        labelTube2.Text = "Jam";
                        labelTube2.BackColor = Color.Red;
                    }
                }
                else if (RxByte[4] > 0)
                {
                    labelTube2.Text = String.Format("{0:D}", RxByte[4]);
                    labelTube2.BackColor = Color.Gold;
                }
                if ((RxByte[1] & 0x08) > 0)
                {
                    if (RxByte[5] > 0)
                    {
                        labelTube3.Text = "Full";
                        labelTube3.BackColor = Color.Gold;
                    }
                    else
                    {
                        labelTube3.Text = "Jam";
                        labelTube3.BackColor = Color.Red;
                    }
                }
                else if (RxByte[5] > 0)
                {
                    labelTube3.Text = String.Format("{0:D}", RxByte[5]);
                    labelTube3.BackColor = Color.Gold;
                }
                if ((RxByte[1] & 0x10) > 0)
                {
                    if (RxByte[6] > 0)
                    {
                        labelTube4.Text = "Full";
                        labelTube4.BackColor = Color.Gold;
                    }
                    else
                    {
                        labelTube4.Text = "Jam";
                        labelTube4.BackColor = Color.Red;
                    }
                }
                else if (RxByte[6] > 0)
                {
                    labelTube4.Text = String.Format("{0:D}", RxByte[6]);
                    labelTube4.BackColor = Color.Gold;
                }
                if ((RxByte[1] & 0x20) > 0)
                {
                    if (RxByte[7] > 0)
                    {
                        labelTube5.Text = "Full";
                        labelTube5.BackColor = Color.Gold;
                    }
                    else
                    {
                        labelTube5.Text = "Jam";
                        labelTube5.BackColor = Color.Red;
                    }
                }
                else if (RxByte[7] > 0)
                {
                    labelTube5.Text = String.Format("{0:D}", RxByte[7]);
                    labelTube5.BackColor = Color.Gold;
                }
                if ((RxByte[1] & 0x40) > 0)
                {
                    if (RxByte[8] > 0)
                    {
                        labelTube6.Text = "Full";
                        labelTube6.BackColor = Color.Gold;
                    }
                    else
                    {
                        labelTube6.Text = "Jam";
                        labelTube6.BackColor = Color.Red;
                    }
                }
                else if (RxByte[8] > 0)
                {
                    labelTube6.Text = String.Format("{0:D}", RxByte[8]);
                    labelTube6.BackColor = Color.Gold;
                }
                if ((RxByte[1] & 0x80) > 0)
                {
                    if (RxByte[9] > 0)
                    {
                        labelTube7.Text = "Full";
                        labelTube7.BackColor = Color.Gold;
                    }
                    else
                    {
                        labelTube7.Text = "Jam";
                        labelTube7.BackColor = Color.Red;
                    }
                }
                else if (RxByte[9] > 0)
                {
                    labelTube7.Text = String.Format("{0:D}", RxByte[9]);
                    labelTube7.BackColor = Color.Gold;
                }
                if ((RxByte[0] & 0x01) > 0)
                {
                    if (RxByte[10] > 0)
                    {
                        labelTube8.Text = "Full";
                        labelTube8.BackColor = Color.Gold;
                    }
                    else
                    {
                        labelTube8.Text = "Jam";
                        labelTube8.BackColor = Color.Red;
                    }
                }
                else if (RxByte[10] > 0)
                {
                    labelTube8.Text = String.Format("{0:D}", RxByte[10]);
                    labelTube8.BackColor = Color.Gold;
                }
                if ((RxByte[0] & 0x02) > 0)
                {
                    if (RxByte[11] > 0)
                    {
                        labelTube9.Text = "Full";
                        labelTube9.BackColor = Color.Gold;
                    }
                    else
                    {
                        labelTube9.Text = "Jam";
                        labelTube9.BackColor = Color.Red;
                    }
                }
                else if (RxByte[11] > 0)
                {
                    labelTube9.Text = String.Format("{0:D}", RxByte[11]);
                    labelTube9.BackColor = Color.Gold;
                }
                if ((RxByte[0] & 0x04) > 0)
                {
                    if (RxByte[12] > 0)
                    {
                        labelTube10.Text = "Full";
                        labelTube10.BackColor = Color.Gold;
                    }
                    else
                    {
                        labelTube10.Text = "Jam";
                        labelTube10.BackColor = Color.Red;
                    }
                }
                else if (RxByte[12] > 0)
                {
                    labelTube10.Text = String.Format("{0:D}", RxByte[12]);
                    labelTube10.BackColor = Color.Gold;
                }
                if ((RxByte[0] & 0x08) > 0)
                {
                    if (RxByte[13] > 0)
                    {
                        labelTube11.Text = "Full";
                        labelTube11.BackColor = Color.Gold;
                    }
                    else
                    {
                        labelTube11.Text = "Jam";
                        labelTube11.BackColor = Color.Red;
                    }
                }
                else if (RxByte[13] > 0)
                {
                    labelTube11.Text = String.Format("{0:D}", RxByte[13]);
                    labelTube11.BackColor = Color.Gold;
                }
                if ((RxByte[0] & 0x10) > 0)
                {
                    if (RxByte[14] > 0)
                    {
                        labelTube12.Text = "Full";
                        labelTube12.BackColor = Color.Gold;
                    }
                    else
                    {
                        labelTube12.Text = "Jam";
                        labelTube12.BackColor = Color.Red;
                    }
                }
                else if (RxByte[14] > 0)
                {
                    labelTube12.Text = String.Format("{0:D}", RxByte[14]);
                    labelTube12.BackColor = Color.Gold;
                }
                if ((RxByte[0] & 0x20) > 0)
                {
                    if (RxByte[15] > 0)
                    {
                        labelTube13.Text = "Full";
                        labelTube13.BackColor = Color.Gold;
                    }
                    else
                    {
                        labelTube13.Text = "Jam";
                        labelTube13.BackColor = Color.Red;
                    }
                }
                else if (RxByte[15] > 0)
                {
                    labelTube13.Text = String.Format("{0:D}", RxByte[15]);
                    labelTube13.BackColor = Color.Gold;
                }
                if ((RxByte[0] & 0x40) > 0)
                {
                    if (RxByte[16] > 0)
                    {
                        labelTube14.Text = "Full";
                        labelTube14.BackColor = Color.Gold;
                    }
                    else
                    {
                        labelTube14.Text = "Jam";
                        labelTube14.BackColor = Color.Red;
                    }
                }
                else if (RxByte[16] > 0)
                {
                    labelTube14.Text = String.Format("{0:D}", RxByte[16]);
                    labelTube14.BackColor = Color.Gold;
                }
                if ((RxByte[0] & 0x80) > 0)
                {
                    if (RxByte[17] > 0)
                    {
                        labelTube15.Text = "Full";
                        labelTube15.BackColor = Color.Gold;
                    }
                    else
                    {
                        labelTube15.Text = "Jam";
                        labelTube15.BackColor = Color.Red;
                    }
                }
                else if (RxByte[17] > 0)
                {
                    labelTube15.Text = String.Format("{0:D}", RxByte[17]);
                    labelTube15.BackColor = Color.Gold;
                }
            }
        }

        private void buttonDispenseMDBCoinsByType_Click(object sender, EventArgs e)
        {
            byte Type, Amount;
            Type = (byte)numericUpDownDispenseMDBCoinsByType1.Value;
            Amount = (byte)numericUpDownDispenseMDBCoinsByType2.Value;
            int result = SR1.dispenseMDBCoinsByType(Type, Amount);
            labelRtnDispenseMDBCoinsByType.Text = Convert.ToString(result);
        }

        private void buttonClearCoinAmount_Click(object sender, EventArgs e)
        {
            if (labelCoinScale.Text == "0")
            {
                labelCoinStatusLightBox_CreditAmount.Text = "???";
                labelCoinStatusLightBox_ManualAmount.Text = "???";
            }
            else
            {
            labelCoinStatusLightBox_CreditAmount.Text = "0";
            labelCoinStatusLightBox_ManualAmount.Text = "0";
            }
        }

        private void buttonGetMDBBillSetup_Click(object sender, EventArgs e)
        {
            byte[] RxByte = new byte[1];            // array to hold receive data
            int RxSize = 0;
            // clear previous display
            labelMiscMDBCmdRepliedString.Text = "";
            labelBillLevel.Text = "0";
            labelBillLevel.BackColor = Color.Gray;
            labelBillISO.Text = "0";
            labelBillISO.BackColor = Color.Gray;
            labelBillScale.Text = "0";
            labelBillScale.BackColor = Color.Gray;
            labelBillDecimal.Text = "0";
            labelBillDecimal.BackColor = Color.Gray;
            labelBillCh0.Text = "0";
            labelBillCh0.BackColor = Color.Gray;
            labelBillCh1.Text = "0";
            labelBillCh1.BackColor = Color.Gray;
            labelBillCh2.Text = "0";
            labelBillCh2.BackColor = Color.Gray;
            labelBillCh3.Text = "0";
            labelBillCh3.BackColor = Color.Gray;
            labelBillCh4.Text = "0";
            labelBillCh4.BackColor = Color.Gray;
            labelBillCh5.Text = "0";
            labelBillCh5.BackColor = Color.Gray;
            labelBillCh6.Text = "0";
            labelBillCh6.BackColor = Color.Gray;
            labelBillCh7.Text = "0";
            labelBillCh7.BackColor = Color.Gray;
            labelBillCh8.Text = "0";
            labelBillCh8.BackColor = Color.Gray;
            labelBillCh9.Text = "0";
            labelBillCh9.BackColor = Color.Gray;
            labelBillCh10.Text = "0";
            labelBillCh10.BackColor = Color.Gray;
            labelBillCh11.Text = "0";
            labelBillCh11.BackColor = Color.Gray;
            labelBillCh12.Text = "0";
            labelBillCh12.BackColor = Color.Gray;
            labelBillCh13.Text = "0";
            labelBillCh13.BackColor = Color.Gray;
            labelBillCh14.Text = "0";
            labelBillCh14.BackColor = Color.Gray;
            labelBillCh15.Text = "0";
            labelBillCh15.BackColor = Color.Gray;
            int result = SR1.getMDBBillSetup(ref RxByte, ref RxSize);
            labelRtnGetMDBBillSetup.Text = Convert.ToString(result);
            if (result == 0)
            {
                string displayString = null;
                for (int loop = 0; loop < RxSize; loop++)
                {
                    displayString += String.Format("{0,3:X}", RxByte[loop]);  // padding 3, display Hex value
                }
                labelMiscMDBCmdRepliedString.Text = displayString;
                // show info
                labelBillLevel.Text = String.Format("{0:X}", RxByte[0]);
                labelBillLevel.BackColor = Color.Gold;
                labelBillISO.Text = String.Format("{0:X}", RxByte[1]) + String.Format("{0:X}", RxByte[2]);
                labelBillISO.BackColor = Color.Gold;
                int billScale = (int)(RxByte[3] * 256 + RxByte[4]);
                labelBillScale.Text = String.Format("{0:D}", billScale);
                labelBillScale.BackColor = Color.Gold;
                labelBillDecimal.Text = String.Format("{0:D}", RxByte[5]);
                labelBillDecimal.BackColor = Color.Gold;
                // set numeric controls for Dispense by Value
                numericUpDownDispenseMDBCoinsByValue.DecimalPlaces = RxByte[5];
                switch (RxByte[5])
                {
                    case 0:
                        numericUpDownDispenseMDBBillsByValue.Increment = 1;
                        break;
                    case 1:
                        numericUpDownDispenseMDBBillsByValue.Increment = (decimal)0.1;
                        break;
                    case 2:
                        numericUpDownDispenseMDBBillsByValue.Increment = (decimal)0.01;
                        break;
                    case 3:
                        numericUpDownDispenseMDBBillsByValue.Increment = (decimal)0.001;
                        break;
                    case 4:
                        numericUpDownDispenseMDBBillsByValue.Increment = (decimal)0.0001;
                        break;
                }
                if (RxByte[11] > 0)
                {
                    if (RxByte[11] == 255)
                    {
                        labelBillCh0.Text = "Token";
                    }
                    else
                    {
                        labelBillCh0.Text = ConvertToCurrencyString(RxByte[11], billScale, RxByte[5]);
                    }
                    labelBillCh0.BackColor = Color.Gold;
                }
                if (RxByte[12] > 0)
                {
                    if (RxByte[12] == 255)
                    {
                        labelBillCh1.Text = "Token";
                    }
                    else
                    {
                        labelBillCh1.Text = ConvertToCurrencyString(RxByte[12], billScale, RxByte[5]);
                    }
                    labelBillCh1.BackColor = Color.Gold;
                }
                if (RxByte[13] > 0)
                {
                    if (RxByte[13] == 255)
                    {
                        labelBillCh2.Text = "Token";
                    }
                    else
                    {
                        labelBillCh2.Text = ConvertToCurrencyString(RxByte[13], billScale, RxByte[5]);
                    }
                    labelBillCh2.BackColor = Color.Gold;
                }
                if (RxByte[14] > 0)
                {
                    if (RxByte[14] == 255)
                    {
                        labelBillCh3.Text = "Token";
                    }
                    else
                    {
                        labelBillCh3.Text = ConvertToCurrencyString(RxByte[14], billScale, RxByte[5]);
                    }
                    labelBillCh3.BackColor = Color.Gold;
                }
                if (RxByte[15] > 0)
                {
                    if (RxByte[15] == 255)
                    {
                        labelBillCh4.Text = "Token";
                    }
                    else
                    {
                        labelBillCh4.Text = ConvertToCurrencyString(RxByte[15], billScale, RxByte[5]);
                    }
                    labelBillCh4.BackColor = Color.Gold;
                }
                if (RxByte[16] > 0)
                {
                    if (RxByte[16] == 255)
                    {
                        labelBillCh5.Text = "Token";
                    }
                    else
                    {
                        labelBillCh5.Text = ConvertToCurrencyString(RxByte[16], billScale, RxByte[5]);
                    }
                    labelBillCh5.BackColor = Color.Gold;
                }
                if (RxByte[17] > 0)
                {
                    if (RxByte[17] == 255)
                    {
                        labelBillCh6.Text = "Token";
                    }
                    else
                    {
                        labelBillCh6.Text = ConvertToCurrencyString(RxByte[17], billScale, RxByte[5]);
                    }
                    labelBillCh6.BackColor = Color.Gold;
                }
                if (RxByte[18] > 0)
                {
                    if (RxByte[18] == 255)
                    {
                        labelBillCh7.Text = "Token";
                    }
                    else
                    {
                        labelBillCh7.Text = ConvertToCurrencyString(RxByte[18], billScale, RxByte[5]);
                    }
                    labelBillCh7.BackColor = Color.Gold;
                }
                if (RxByte[19] > 0)
                {
                    if (RxByte[19] == 255)
                    {
                        labelBillCh8.Text = "Token";
                    }
                    else
                    {
                        labelBillCh8.Text = ConvertToCurrencyString(RxByte[19], billScale, RxByte[5]);
                    }
                    labelBillCh8.BackColor = Color.Gold;
                }
                if (RxByte[20] > 0)
                {
                    if (RxByte[20] == 255)
                    {
                        labelBillCh9.Text = "Token";
                    }
                    else
                    {
                        labelBillCh9.Text = ConvertToCurrencyString(RxByte[20], billScale, RxByte[5]);
                    }
                    labelBillCh9.BackColor = Color.Gold;
                }
                if (RxByte[21] > 0)
                {
                    if (RxByte[21] == 255)
                    {
                        labelBillCh10.Text = "Token";
                    }
                    else
                    {
                        labelBillCh10.Text = ConvertToCurrencyString(RxByte[21], billScale, RxByte[5]);
                    }
                    labelBillCh10.BackColor = Color.Gold;
                }
                if (RxByte[22] > 0)
                {
                    if (RxByte[22] == 255)
                    {
                        labelBillCh11.Text = "Token";
                    }
                    else
                    {
                        labelBillCh11.Text = ConvertToCurrencyString(RxByte[22], billScale, RxByte[5]);
                    }
                    labelBillCh11.BackColor = Color.Gold;
                }
                if (RxByte[23] > 0)
                {
                    if (RxByte[23] == 255)
                    {
                        labelBillCh12.Text = "Token";
                    }
                    else
                    {
                        labelBillCh12.Text = ConvertToCurrencyString(RxByte[23], billScale, RxByte[5]);
                    }
                    labelBillCh12.BackColor = Color.Gold;
                }
                if (RxByte[24] > 0)
                {
                    if (RxByte[24] == 255)
                    {
                        labelBillCh13.Text = "Token";
                    }
                    else
                    {
                        labelBillCh13.Text = ConvertToCurrencyString(RxByte[24], billScale, RxByte[5]);
                    }
                    labelBillCh13.BackColor = Color.Gold;
                }
                if (RxByte[25] > 0)
                {
                    if (RxByte[25] == 255)
                    {
                        labelBillCh14.Text = "Token";
                    }
                    else
                    {
                        labelBillCh14.Text = ConvertToCurrencyString(RxByte[25], billScale, RxByte[5]);
                    }
                    labelBillCh14.BackColor = Color.Gold;
                }
                if (RxByte[26] > 0)
                {
                    if (RxByte[26] == 255)
                    {
                        labelBillCh15.Text = "Token";
                    }
                    else
                    {
                        labelBillCh15.Text = ConvertToCurrencyString(RxByte[26], billScale, RxByte[5]);
                    }
                    labelBillCh15.BackColor = Color.Gold;
                }
            }
        }

        private void buttonMDBBillEscrowAccept_Click(object sender, EventArgs e)
        {
            int result = SR1.setMDBBillEscrow(1);
            buttonMDBBillEscrowAccept.BackColor = Color.Gray;
            buttonMDBBillEscrowReturn.BackColor = Color.Gray;
            if (labelBillStatusLightBox_EscrowedAmount.Text != "???") labelBillStatusLightBox_EscrowedAmount.Text = "0";
        }

        private void buttonMDBBillEscrowReturn_Click(object sender, EventArgs e)
        {
            int result = SR1.setMDBBillEscrow(0);
            buttonMDBBillEscrowAccept.BackColor = Color.Gray;
            buttonMDBBillEscrowReturn.BackColor = Color.Gray;
            if (labelBillStatusLightBox_EscrowedAmount.Text != "???") labelBillStatusLightBox_EscrowedAmount.Text = "0";
        }

        private void buttonSetMDBBillChannels_Click(object sender, EventArgs e)
        {
            byte hiByte = 0;
            byte loByte = 0;
            if (checkBoxBillEnable0.Checked) loByte = 1;
            if (checkBoxBillEnable1.Checked) loByte += 2;
            if (checkBoxBillEnable2.Checked) loByte += 4;
            if (checkBoxBillEnable3.Checked) loByte += 8;
            if (checkBoxBillEnable4.Checked) loByte += 16;
            if (checkBoxBillEnable5.Checked) loByte += 32;
            if (checkBoxBillEnable6.Checked) loByte += 64;
            if (checkBoxBillEnable7.Checked) loByte += 128;
            if (checkBoxBillEnable8.Checked) hiByte = 1;
            if (checkBoxBillEnable9.Checked) hiByte += 2;
            if (checkBoxBillEnable10.Checked) hiByte += 4;
            if (checkBoxBillEnable11.Checked) hiByte += 8;
            if (checkBoxBillEnable12.Checked) hiByte += 16;
            if (checkBoxBillEnable13.Checked) hiByte += 32;
            if (checkBoxBillEnable14.Checked) hiByte += 64;
            if (checkBoxBillEnable15.Checked) hiByte += 128;
            int result = SR1.setMDBBillEnable(hiByte, loByte);
            labelRtnSetMDBBillChannels.Text = Convert.ToString(result);
        }

        private void buttonClearBillAmount_Click(object sender, EventArgs e)
        {
            if (labelBillScale.Text == "0")
            {
                labelBillStatusLightBox_ManualDispensedAmount.Text = "???";
                labelBillStatusLightBox_ManualFilledAmount.Text = "???";
                labelBillStatusLightBox_EscrowedAmount.Text = "???";
                labelBillStatusLightBox_CreditAmount.Text = "???";
                labelBillStatusLightBox_TransferredAmount.Text = "???";
            }
            else
            {
                labelBillStatusLightBox_ManualDispensedAmount.Text = "0";
                labelBillStatusLightBox_ManualFilledAmount.Text = "0";
                labelBillStatusLightBox_EscrowedAmount.Text = "0";
                labelBillStatusLightBox_CreditAmount.Text = "0";
                labelBillStatusLightBox_TransferredAmount.Text = "0";
            }
        }

        private void buttonGetMDBRecyclerRouteTable_Click(object sender, EventArgs e)
        {
            byte[] RxByte = new byte[1];            // array to hold receive data
            int RxSize = 0;
            // clear previous display
            labelMiscMDBCmdRepliedString.Text = "";
            labelRouteTable0.Text = "0";
            labelRouteTable0.BackColor = Color.Gray;
            labelRouteTable1.Text = "0";
            labelRouteTable1.BackColor = Color.Gray;
            labelRouteTable2.Text = "0";
            labelRouteTable2.BackColor = Color.Gray;
            labelRouteTable3.Text = "0";
            labelRouteTable3.BackColor = Color.Gray;
            labelRouteTable4.Text = "0";
            labelRouteTable4.BackColor = Color.Gray;
            labelRouteTable5.Text = "0";
            labelRouteTable5.BackColor = Color.Gray;
            labelRouteTable6.Text = "0";
            labelRouteTable6.BackColor = Color.Gray;
            labelRouteTable7.Text = "0";
            labelRouteTable7.BackColor = Color.Gray;
            labelRouteTable8.Text = "0";
            labelRouteTable8.BackColor = Color.Gray;
            labelRouteTable9.Text = "0";
            labelRouteTable9.BackColor = Color.Gray;
            labelRouteTable10.Text = "0";
            labelRouteTable10.BackColor = Color.Gray;
            labelRouteTable11.Text = "0";
            labelRouteTable11.BackColor = Color.Gray;
            labelRouteTable12.Text = "0";
            labelRouteTable12.BackColor = Color.Gray;
            labelRouteTable13.Text = "0";
            labelRouteTable13.BackColor = Color.Gray;
            labelRouteTable14.Text = "0";
            labelRouteTable14.BackColor = Color.Gray;
            labelRouteTable15.Text = "0";
            labelRouteTable15.BackColor = Color.Gray;
            int result = SR1.getMDBBillRecyclerRouting(ref RxByte, ref RxSize);
            labelRtnGetMDBRecyclerRouteTable.Text = Convert.ToString(result);
            if (result == 0)
            {
                string displayString = null;
                for (int loop = 0; loop < RxSize; loop++)
                {
                    displayString += String.Format("{0,3:X}", RxByte[loop]);  // padding 3, display Hex value
                }
                labelMiscMDBCmdRepliedString.Text = displayString;
                // show info
                if ((RxByte[0] & 0x80) > 0)
                {
                    labelRouteTable15.Text = "1";
                    labelRouteTable15.BackColor = Color.Yellow;
                }
                if ((RxByte[0] & 0x40) > 0)
                {
                    labelRouteTable14.Text = "1";
                    labelRouteTable14.BackColor = Color.Yellow;
                }
                if ((RxByte[0] & 0x20) > 0)
                {
                    labelRouteTable13.Text = "1";
                    labelRouteTable13.BackColor = Color.Yellow;
                }
                if ((RxByte[0] & 0x10) > 0)
                {
                    labelRouteTable12.Text = "1";
                    labelRouteTable12.BackColor = Color.Yellow;
                }
                if ((RxByte[0] & 0x08) > 0)
                {
                    labelRouteTable11.Text = "1";
                    labelRouteTable11.BackColor = Color.Yellow;
                }
                if ((RxByte[0] & 0x04) > 0)
                {
                    labelRouteTable10.Text = "1";
                    labelRouteTable10.BackColor = Color.Yellow;
                }
                if ((RxByte[0] & 0x02) > 0)
                {
                    labelRouteTable9.Text = "1";
                    labelRouteTable9.BackColor = Color.Yellow;
                }
                if ((RxByte[0] & 0x01) > 0)
                {
                    labelRouteTable8.Text = "1";
                    labelRouteTable8.BackColor = Color.Yellow;
                }
                if ((RxByte[1] & 0x80) > 0)
                {
                    labelRouteTable7.Text = "1";
                    labelRouteTable7.BackColor = Color.Yellow;
                }
                if ((RxByte[1] & 0x40) > 0)
                {
                    labelRouteTable6.Text = "1";
                    labelRouteTable6.BackColor = Color.Yellow;
                }
                if ((RxByte[1] & 0x20) > 0)
                {
                    labelRouteTable5.Text = "1";
                    labelRouteTable5.BackColor = Color.Yellow;
                }
                if ((RxByte[1] & 0x10) > 0)
                {
                    labelRouteTable4.Text = "1";
                    labelRouteTable4.BackColor = Color.Yellow;
                }
                if ((RxByte[1] & 0x08) > 0)
                {
                    labelRouteTable3.Text = "1";
                    labelRouteTable3.BackColor = Color.Yellow;
                }
                if ((RxByte[1] & 0x04) > 0)
                {
                    labelRouteTable2.Text = "1";
                    labelRouteTable2.BackColor = Color.Yellow;
                }
                if ((RxByte[1] & 0x02) > 0)
                {
                    labelRouteTable1.Text = "1";
                    labelRouteTable1.BackColor = Color.Yellow;
                }
                if ((RxByte[1] & 0x01) > 0)
                {
                    labelRouteTable0.Text = "1";
                    labelRouteTable0.BackColor = Color.Yellow;
                }
            }
        }

        private void buttonSetMDBRecyclerRouteEnable_Click(object sender, EventArgs e)
        {
            byte hiByte = 0;
            byte loByte = 0;
            if (checkBoxRouteEnable0.Checked) loByte = 1;
            if (checkBoxRouteEnable1.Checked) loByte += 2;
            if (checkBoxRouteEnable2.Checked) loByte += 4;
            if (checkBoxRouteEnable3.Checked) loByte += 8;
            if (checkBoxRouteEnable4.Checked) loByte += 16;
            if (checkBoxRouteEnable5.Checked) loByte += 32;
            if (checkBoxRouteEnable6.Checked) loByte += 64;
            if (checkBoxRouteEnable7.Checked) loByte += 128;
            if (checkBoxRouteEnable8.Checked) hiByte = 1;
            if (checkBoxRouteEnable9.Checked) hiByte += 2;
            if (checkBoxRouteEnable10.Checked) hiByte += 4;
            if (checkBoxRouteEnable11.Checked) hiByte += 8;
            if (checkBoxRouteEnable12.Checked) hiByte += 16;
            if (checkBoxRouteEnable13.Checked) hiByte += 32;
            if (checkBoxRouteEnable14.Checked) hiByte += 64;
            if (checkBoxRouteEnable15.Checked) hiByte += 128;
            int result = SR1.setMDBBillRecyclerEnable(hiByte, loByte);
            labelRtnSetMDBRecyclerRouteEnable.Text = Convert.ToString(result);
        }

        private void buttonGetMDBRecyclerContent_Click(object sender, EventArgs e)
        {
            byte[] RxByte = new byte[1];            // array to hold receive data
            int RxSize = 0;
            // clear previous display
            labelMiscMDBCmdRepliedString.Text = "";
            labelRecyclerContent0.Text = "0";
            labelRecyclerContent0.BackColor = Color.Gray;
            labelRecyclerContent1.Text = "0";
            labelRecyclerContent1.BackColor = Color.Gray;
            labelRecyclerContent2.Text = "0";
            labelRecyclerContent2.BackColor = Color.Gray;
            labelRecyclerContent3.Text = "0";
            labelRecyclerContent3.BackColor = Color.Gray;
            labelRecyclerContent4.Text = "0";
            labelRecyclerContent4.BackColor = Color.Gray;
            labelRecyclerContent5.Text = "0";
            labelRecyclerContent5.BackColor = Color.Gray;
            labelRecyclerContent6.Text = "0";
            labelRecyclerContent6.BackColor = Color.Gray;
            labelRecyclerContent7.Text = "0";
            labelRecyclerContent7.BackColor = Color.Gray;
            labelRecyclerContent8.Text = "0";
            labelRecyclerContent8.BackColor = Color.Gray;
            labelRecyclerContent9.Text = "0";
            labelRecyclerContent9.BackColor = Color.Gray;
            labelRecyclerContent10.Text = "0";
            labelRecyclerContent10.BackColor = Color.Gray;
            labelRecyclerContent11.Text = "0";
            labelRecyclerContent11.BackColor = Color.Gray;
            labelRecyclerContent12.Text = "0";
            labelRecyclerContent12.BackColor = Color.Gray;
            labelRecyclerContent13.Text = "0";
            labelRecyclerContent13.BackColor = Color.Gray;
            labelRecyclerContent14.Text = "0";
            labelRecyclerContent14.BackColor = Color.Gray;
            labelRecyclerContent15.Text = "0";
            labelRecyclerContent15.BackColor = Color.Gray;
            int result = SR1.getMDBBillRecyclerContent(ref RxByte, ref RxSize);
            labelRtnGetMDBRecyclerContent.Text = Convert.ToString(result);
            if (result == 0)
            {
                string displayString = null;
                for (int loop = 0; loop < RxSize; loop++)
                {
                    displayString += String.Format("{0,3:X}", RxByte[loop]);  // padding 3, display Hex value
                }
                labelMiscMDBCmdRepliedString.Text = displayString;
                // show info
                if ((RxByte[1] & 0x01) > 0)
                {
                    if (RxByte[2] * 256 + RxByte[3] > 0)
                    {
                        labelRecyclerContent0.Text = "Full";
                        labelRecyclerContent0.BackColor = Color.Gold;
                    }
                    else
                    {
                        labelRecyclerContent0.Text = "Jam";
                        labelRecyclerContent0.BackColor = Color.Red;
                    }
                }
                else if (RxByte[2] * 256 + RxByte[3] > 0)
                {
                    labelRecyclerContent0.Text = String.Format("{0:D}", RxByte[2] * 256 + RxByte[3]);
                    labelRecyclerContent0.BackColor = Color.Gold;
                }
                if ((RxByte[1] & 0x02) > 0)
                {
                    if (RxByte[4] * 256 + RxByte[5] > 0)
                    {
                        labelRecyclerContent1.Text = "Full";
                        labelRecyclerContent1.BackColor = Color.Gold;
                    }
                    else
                    {
                        labelRecyclerContent1.Text = "Jam";
                        labelRecyclerContent1.BackColor = Color.Red;
                    }
                }
                else if (RxByte[4] * 256 + RxByte[5] > 0)
                {
                    labelRecyclerContent1.Text = String.Format("{0:D}", RxByte[4] * 256 + RxByte[5]);
                    labelRecyclerContent1.BackColor = Color.Gold;
                }
                if ((RxByte[1] & 0x04) > 0)
                {
                    if (RxByte[6] * 256 + RxByte[7] > 0)
                    {
                        labelRecyclerContent2.Text = "Full";
                        labelRecyclerContent2.BackColor = Color.Gold;
                    }
                    else
                    {
                        labelRecyclerContent2.Text = "Jam";
                        labelRecyclerContent2.BackColor = Color.Red;
                    }
                }
                else if (RxByte[6] * 256 + RxByte[7] > 0)
                {
                    labelRecyclerContent2.Text = String.Format("{0:D}", RxByte[6] * 256 + RxByte[7]);
                    labelRecyclerContent2.BackColor = Color.Gold;
                }
                if ((RxByte[1] & 0x08) > 0)
                {
                    if (RxByte[8] * 256 + RxByte[9] > 0)
                    {
                        labelRecyclerContent3.Text = "Full";
                        labelRecyclerContent3.BackColor = Color.Gold;
                    }
                    else
                    {
                        labelRecyclerContent3.Text = "Jam";
                        labelRecyclerContent3.BackColor = Color.Red;
                    }
                }
                else if (RxByte[8] * 256 + RxByte[9] > 0)
                {
                    labelRecyclerContent3.Text = String.Format("{0:D}", RxByte[8] * 256 + RxByte[9]);
                    labelRecyclerContent3.BackColor = Color.Gold;
                }
                if ((RxByte[1] & 0x10) > 0)
                {
                    if (RxByte[10] * 256 + RxByte[11] > 0)
                    {
                        labelRecyclerContent4.Text = "Full";
                        labelRecyclerContent4.BackColor = Color.Gold;
                    }
                    else
                    {
                        labelRecyclerContent4.Text = "Jam";
                        labelRecyclerContent4.BackColor = Color.Red;
                    }
                }
                else if (RxByte[10] * 256 + RxByte[11] > 0)
                {
                    labelRecyclerContent4.Text = String.Format("{0:D}", RxByte[10] * 256 + RxByte[11]);
                    labelRecyclerContent4.BackColor = Color.Gold;
                }
                if ((RxByte[1] & 0x20) > 0)
                {
                    if (RxByte[12] * 256 + RxByte[13] > 0)
                    {
                        labelRecyclerContent5.Text = "Full";
                        labelRecyclerContent5.BackColor = Color.Gold;
                    }
                    else
                    {
                        labelRecyclerContent5.Text = "Jam";
                        labelRecyclerContent5.BackColor = Color.Red;
                    }
                }
                else if (RxByte[12] * 256 + RxByte[13] > 0)
                {
                    labelRecyclerContent5.Text = String.Format("{0:D}", RxByte[12] * 256 + RxByte[13]);
                    labelRecyclerContent5.BackColor = Color.Gold;
                }
                if ((RxByte[1] & 0x40) > 0)
                {
                    if (RxByte[14] * 256 + RxByte[15] > 0)
                    {
                        labelRecyclerContent6.Text = "Full";
                        labelRecyclerContent6.BackColor = Color.Gold;
                    }
                    else
                    {
                        labelRecyclerContent6.Text = "Jam";
                        labelRecyclerContent6.BackColor = Color.Red;
                    }
                }
                else if (RxByte[14] * 256 + RxByte[15] > 0)
                {
                    labelRecyclerContent6.Text = String.Format("{0:D}", RxByte[14] * 256 + RxByte[15]);
                    labelRecyclerContent6.BackColor = Color.Gold;
                }
                if ((RxByte[1] & 0x80) > 0)
                {
                    if (RxByte[16] * 256 + RxByte[17] > 0)
                    {
                        labelRecyclerContent7.Text = "Full";
                        labelRecyclerContent7.BackColor = Color.Gold;
                    }
                    else
                    {
                        labelRecyclerContent7.Text = "Jam";
                        labelRecyclerContent7.BackColor = Color.Red;
                    }
                }
                else if (RxByte[16] * 256 + RxByte[17] > 0)
                {
                    labelRecyclerContent7.Text = String.Format("{0:D}", RxByte[16] * 256 + RxByte[17]);
                    labelRecyclerContent7.BackColor = Color.Gold;
                }
                if ((RxByte[0] & 0x01) > 0)
                {
                    if (RxByte[18] * 256 + RxByte[19] > 0)
                    {
                        labelRecyclerContent8.Text = "Full";
                        labelRecyclerContent8.BackColor = Color.Gold;
                    }
                    else
                    {
                        labelRecyclerContent8.Text = "Jam";
                        labelRecyclerContent8.BackColor = Color.Red;
                    }
                }
                else if (RxByte[18] * 256 + RxByte[19] > 0)
                {
                    labelRecyclerContent8.Text = String.Format("{0:D}", RxByte[18] * 256 + RxByte[19]);
                    labelRecyclerContent8.BackColor = Color.Gold;
                }
                if ((RxByte[0] & 0x02) > 0)
                {
                    if (RxByte[20] * 256 + RxByte[21] > 0)
                    {
                        labelRecyclerContent9.Text = "Full";
                        labelRecyclerContent9.BackColor = Color.Gold;
                    }
                    else
                    {
                        labelRecyclerContent9.Text = "Jam";
                        labelRecyclerContent9.BackColor = Color.Red;
                    }
                }
                else if (RxByte[20] * 256 + RxByte[21] > 0)
                {
                    labelRecyclerContent9.Text = String.Format("{0:D}", RxByte[20] * 256 + RxByte[21]);
                    labelRecyclerContent9.BackColor = Color.Gold;
                }
                if ((RxByte[0] & 0x04) > 0)
                {
                    if (RxByte[22] * 256 + RxByte[23] > 0)
                    {
                        labelRecyclerContent10.Text = "Full";
                        labelRecyclerContent10.BackColor = Color.Gold;
                    }
                    else
                    {
                        labelRecyclerContent10.Text = "Jam";
                        labelRecyclerContent10.BackColor = Color.Red;
                    }
                }
                else if (RxByte[22] * 256 + RxByte[23] > 0)
                {
                    labelRecyclerContent10.Text = String.Format("{0:D}", RxByte[22] * 256 + RxByte[23]);
                    labelRecyclerContent10.BackColor = Color.Gold;
                }
                if ((RxByte[0] & 0x08) > 0)
                {
                    if (RxByte[24] * 256 + RxByte[25] > 0)
                    {
                        labelRecyclerContent11.Text = "Full";
                        labelRecyclerContent11.BackColor = Color.Gold;
                    }
                    else
                    {
                        labelRecyclerContent11.Text = "Jam";
                        labelRecyclerContent11.BackColor = Color.Red;
                    }
                }
                else if (RxByte[24] * 256 + RxByte[25] > 0)
                {
                    labelRecyclerContent11.Text = String.Format("{0:D}", RxByte[24] * 256 + RxByte[25]);
                    labelRecyclerContent11.BackColor = Color.Gold;
                }
                if ((RxByte[0] & 0x10) > 0)
                {
                    if (RxByte[26] * 256 + RxByte[27] > 0)
                    {
                        labelRecyclerContent12.Text = "Full";
                        labelRecyclerContent12.BackColor = Color.Gold;
                    }
                    else
                    {
                        labelRecyclerContent12.Text = "Jam";
                        labelRecyclerContent12.BackColor = Color.Red;
                    }
                }
                else if (RxByte[26] * 256 + RxByte[27] > 0)
                {
                    labelRecyclerContent12.Text = String.Format("{0:D}", RxByte[26] * 256 + RxByte[27]);
                    labelRecyclerContent12.BackColor = Color.Gold;
                }
                if ((RxByte[0] & 0x20) > 0)
                {
                    if (RxByte[28] * 256 + RxByte[29] > 0)
                    {
                        labelRecyclerContent13.Text = "Full";
                        labelRecyclerContent13.BackColor = Color.Gold;
                    }
                    else
                    {
                        labelRecyclerContent13.Text = "Jam";
                        labelRecyclerContent13.BackColor = Color.Red;
                    }
                }
                else if (RxByte[28] * 256 + RxByte[29] > 0)
                {
                    labelRecyclerContent13.Text = String.Format("{0:D}", RxByte[28] * 256 + RxByte[29]);
                    labelRecyclerContent13.BackColor = Color.Gold;
                }
                if ((RxByte[0] & 0x40) > 0)
                {
                    if (RxByte[30] * 256 + RxByte[31] > 0)
                    {
                        labelRecyclerContent14.Text = "Full";
                        labelRecyclerContent14.BackColor = Color.Gold;
                    }
                    else
                    {
                        labelRecyclerContent14.Text = "Jam";
                        labelRecyclerContent14.BackColor = Color.Red;
                    }
                }
                else if (RxByte[30] * 256 + RxByte[31] > 0)
                {
                    labelRecyclerContent14.Text = String.Format("{0:D}", RxByte[30] * 256 + RxByte[31]);
                    labelRecyclerContent14.BackColor = Color.Gold;
                }
                if ((RxByte[0] & 0x80) > 0)
                {
                    if (RxByte[32] * 256 + RxByte[33] > 0)
                    {
                        labelRecyclerContent15.Text = "Full";
                        labelRecyclerContent15.BackColor = Color.Gold;
                    }
                    else
                    {
                        labelRecyclerContent15.Text = "Jam";
                        labelRecyclerContent15.BackColor = Color.Red;
                    }
                }
                else if (RxByte[32] * 256 + RxByte[33] > 0)
                {
                    labelRecyclerContent15.Text = String.Format("{0:D}", RxByte[32] * 256 + RxByte[33]);
                    labelRecyclerContent15.BackColor = Color.Gold;
                }
            }

        }

        private void buttonGetMDBRecyclerPayoutFinal_Click(object sender, EventArgs e)
        {
            byte[] RxByte = new byte[1];            // array to hold receive data
            int RxSize = 0;
            // clear previous display
            labelMiscMDBCmdRepliedString.Text = "";
            labelRecyclerPayoutFinal0.Text = "0";
            labelRecyclerPayoutFinal0.BackColor = Color.Gray;
            labelRecyclerPayoutFinal1.Text = "0";
            labelRecyclerPayoutFinal1.BackColor = Color.Gray;
            labelRecyclerPayoutFinal2.Text = "0";
            labelRecyclerPayoutFinal2.BackColor = Color.Gray;
            labelRecyclerPayoutFinal3.Text = "0";
            labelRecyclerPayoutFinal3.BackColor = Color.Gray;
            labelRecyclerPayoutFinal4.Text = "0";
            labelRecyclerPayoutFinal4.BackColor = Color.Gray;
            labelRecyclerPayoutFinal5.Text = "0";
            labelRecyclerPayoutFinal5.BackColor = Color.Gray;
            labelRecyclerPayoutFinal6.Text = "0";
            labelRecyclerPayoutFinal6.BackColor = Color.Gray;
            labelRecyclerPayoutFinal7.Text = "0";
            labelRecyclerPayoutFinal7.BackColor = Color.Gray;
            labelRecyclerPayoutFinal8.Text = "0";
            labelRecyclerPayoutFinal8.BackColor = Color.Gray;
            labelRecyclerPayoutFinal9.Text = "0";
            labelRecyclerPayoutFinal9.BackColor = Color.Gray;
            labelRecyclerPayoutFinal10.Text = "0";
            labelRecyclerPayoutFinal10.BackColor = Color.Gray;
            labelRecyclerPayoutFinal11.Text = "0";
            labelRecyclerPayoutFinal11.BackColor = Color.Gray;
            labelRecyclerPayoutFinal12.Text = "0";
            labelRecyclerPayoutFinal12.BackColor = Color.Gray;
            labelRecyclerPayoutFinal13.Text = "0";
            labelRecyclerPayoutFinal13.BackColor = Color.Gray;
            labelRecyclerPayoutFinal14.Text = "0";
            labelRecyclerPayoutFinal14.BackColor = Color.Gray;
            labelRecyclerPayoutFinal15.Text = "0";
            labelRecyclerPayoutFinal15.BackColor = Color.Gray;
            labelGetMDBRecyclerPayoutFinalAckOnly.Visible = false;

            int result = SR1.getMDBBillPayoutFinal(ref RxByte, ref RxSize);
            labelRtnGetMDBRecyclerPayoutFinal.Text = Convert.ToString(result);
            if (result == 0)
            {
                string displayString = null;
                for (int loop = 0; loop < RxSize; loop++)
                {
                    displayString += String.Format("{0,3:X}", RxByte[loop]);  // padding 3, display Hex value
                }
                labelMiscMDBCmdRepliedString.Text = displayString;
                // make sure this message contains 16 bytes data
                if (RxSize > 15)
                {
                    // show new info
                    if (RxByte[0] * 256 + RxByte[1] > 0)
                    {
                        labelRecyclerPayoutFinal0.Text = String.Format("{0:D}", RxByte[0] * 256 + RxByte[1]);
                        labelRecyclerPayoutFinal0.BackColor = Color.Gold;
                    }
                    else
                    {
                        labelRecyclerPayoutFinal0.Text = "0";
                        labelRecyclerPayoutFinal0.BackColor = Color.Gray;
                    }
                    if (RxByte[2] * 256 + RxByte[3] > 0)
                    {
                        labelRecyclerPayoutFinal1.Text = String.Format("{0:D}", RxByte[2] * 256 + RxByte[3]);
                        labelRecyclerPayoutFinal1.BackColor = Color.Gold;
                    }
                    else
                    {
                        labelRecyclerPayoutFinal1.Text = "0";
                        labelRecyclerPayoutFinal1.BackColor = Color.Gray;
                    }
                    if (RxByte[4] * 256 + RxByte[5] > 0)
                    {
                        labelRecyclerPayoutFinal2.Text = String.Format("{0:D}", RxByte[4] * 256 + RxByte[5]);
                        labelRecyclerPayoutFinal2.BackColor = Color.Gold;
                    }
                    else
                    {
                        labelRecyclerPayoutFinal2.Text = "0";
                        labelRecyclerPayoutFinal2.BackColor = Color.Gray;
                    }
                    if (RxByte[6] * 256 + RxByte[7] > 0)
                    {
                        labelRecyclerPayoutFinal3.Text = String.Format("{0:D}", RxByte[6] * 256 + RxByte[7]);
                        labelRecyclerPayoutFinal3.BackColor = Color.Gold;
                    }
                    else
                    {
                        labelRecyclerPayoutFinal3.Text = "0";
                        labelRecyclerPayoutFinal3.BackColor = Color.Gray;
                    }
                    if (RxByte[8] * 256 + RxByte[9] > 0)
                    {
                        labelRecyclerPayoutFinal4.Text = String.Format("{0:D}", RxByte[8] * 256 + RxByte[9]);
                        labelRecyclerPayoutFinal4.BackColor = Color.Gold;
                    }
                    else
                    {
                        labelRecyclerPayoutFinal4.Text = "0";
                        labelRecyclerPayoutFinal4.BackColor = Color.Gray;
                    }
                    if (RxByte[10] * 256 + RxByte[11] > 0)
                    {
                        labelRecyclerPayoutFinal5.Text = String.Format("{0:D}", RxByte[10] * 256 + RxByte[11]);
                        labelRecyclerPayoutFinal5.BackColor = Color.Gold;
                    }
                    else
                    {
                        labelRecyclerPayoutFinal5.Text = "0";
                        labelRecyclerPayoutFinal5.BackColor = Color.Gray;
                    }
                    if (RxByte[12] * 256 + RxByte[13] > 0)
                    {
                        labelRecyclerPayoutFinal6.Text = String.Format("{0:D}", RxByte[12] * 256 + RxByte[13]);
                        labelRecyclerPayoutFinal6.BackColor = Color.Gold;
                    }
                    else
                    {
                        labelRecyclerPayoutFinal6.Text = "0";
                        labelRecyclerPayoutFinal6.BackColor = Color.Gray;
                    }
                    if (RxByte[14] * 256 + RxByte[15] > 0)
                    {
                        labelRecyclerPayoutFinal7.Text = String.Format("{0:D}", RxByte[14] * 256 + RxByte[15]);
                        labelRecyclerPayoutFinal7.BackColor = Color.Gold;
                    }
                    else
                    {
                        labelRecyclerPayoutFinal7.Text = "0";
                        labelRecyclerPayoutFinal7.BackColor = Color.Gray;
                    }
                    if (RxByte[16] * 256 + RxByte[17] > 0)
                    {
                        labelRecyclerPayoutFinal8.Text = String.Format("{0:D}", RxByte[16] * 256 + RxByte[17]);
                        labelRecyclerPayoutFinal8.BackColor = Color.Gold;
                    }
                    else
                    {
                        labelRecyclerPayoutFinal8.Text = "0";
                        labelRecyclerPayoutFinal8.BackColor = Color.Gray;
                    }
                    if (RxByte[18] * 256 + RxByte[19] > 0)
                    {
                        labelRecyclerPayoutFinal9.Text = String.Format("{0:D}", RxByte[18] * 256 + RxByte[19]);
                        labelRecyclerPayoutFinal9.BackColor = Color.Gold;
                    }
                    else
                    {
                        labelRecyclerPayoutFinal9.Text = "0";
                        labelRecyclerPayoutFinal9.BackColor = Color.Gray;
                    }
                    if (RxByte[20] * 256 + RxByte[21] > 0)
                    {
                        labelRecyclerPayoutFinal10.Text = String.Format("{0:D}", RxByte[20] * 256 + RxByte[21]);
                        labelRecyclerPayoutFinal10.BackColor = Color.Gold;
                    }
                    else
                    {
                        labelRecyclerPayoutFinal10.Text = "0";
                        labelRecyclerPayoutFinal10.BackColor = Color.Gray;
                    }
                    if (RxByte[22] * 256 + RxByte[23] > 0)
                    {
                        labelRecyclerPayoutFinal11.Text = String.Format("{0:D}", RxByte[22] * 256 + RxByte[23]);
                        labelRecyclerPayoutFinal11.BackColor = Color.Gold;
                    }
                    else
                    {
                        labelRecyclerPayoutFinal11.Text = "0";
                        labelRecyclerPayoutFinal11.BackColor = Color.Gray;
                    }
                    if (RxByte[24] * 256 + RxByte[25] > 0)
                    {
                        labelRecyclerPayoutFinal12.Text = String.Format("{0:D}", RxByte[24] * 256 + RxByte[25]);
                        labelRecyclerPayoutFinal12.BackColor = Color.Gold;
                    }
                    else
                    {
                        labelRecyclerPayoutFinal12.Text = "0";
                        labelRecyclerPayoutFinal12.BackColor = Color.Gray;
                    }
                    if (RxByte[26] * 256 + RxByte[27] > 0)
                    {
                        labelRecyclerPayoutFinal13.Text = String.Format("{0:D}", RxByte[26] * 256 + RxByte[27]);
                        labelRecyclerPayoutFinal13.BackColor = Color.Gold;
                    }
                    else
                    {
                        labelRecyclerPayoutFinal13.Text = "0";
                        labelRecyclerPayoutFinal13.BackColor = Color.Gray;
                    }
                    if (RxByte[28] * 256 + RxByte[29] > 0)
                    {
                        labelRecyclerPayoutFinal14.Text = String.Format("{0:D}", RxByte[28] * 256 + RxByte[29]);
                        labelRecyclerPayoutFinal14.BackColor = Color.Gold;
                    }
                    else
                    {
                        labelRecyclerPayoutFinal14.Text = "0";
                        labelRecyclerPayoutFinal14.BackColor = Color.Gray;
                    }
                    if (RxByte[30] * 256 + RxByte[31] > 0)
                    {
                        labelRecyclerPayoutFinal15.Text = String.Format("{0:D}", RxByte[30] * 256 + RxByte[31]);
                        labelRecyclerPayoutFinal15.BackColor = Color.Gold;
                    }
                    else
                    {
                        labelRecyclerPayoutFinal15.Text = "0";
                        labelRecyclerPayoutFinal15.BackColor = Color.Gray;
                    }
                }
                else
                {
                    labelGetMDBRecyclerPayoutFinalAckOnly.Visible = true;
                }

            }

        }

        private void buttonDispenseMDBBillsByType_Click(object sender, EventArgs e)
        {
            byte Type;
            int Value;
            Type = (byte)numericUpDownDispenseMDBBillsByType1.Value;
            Value = (int)numericUpDownDispenseMDBBillsByType2.Value;
            int result = SR1.dispenseMDBBillsByType(Type, Value);
            labelRtnDispenseMDBBillsByType.Text = Convert.ToString(result);
        }

        private void buttonDispenseMDBBillsByValue_Click(object sender, EventArgs e)
        {
            int result = 0;
            float floatValue = (float)numericUpDownDispenseMDBBillsByValue.Value;
            // decimal got from Get Device Setup command
            int Y = Convert.ToInt32(labelBillDecimal.Text);
            // scaling factor got from Get Device Setup command
            int Z = Convert.ToInt32(labelBillScale.Text);
            // quit if Scaling factor = 0
            // run Get Device Setup first
            if (Z == 0)
            {
                result = 2;
            }
            else
            {
                // Amount * 10^Y / Z
                floatValue *= (float)Math.Pow(10, Y);
                int intValue = (int)floatValue / Z;
                // send out command for non-zero integer only
                if ((intValue > 0) && (floatValue % Z == 0))
                {
                    //value = Convert.ToByte(textBoxDispenseMDBCoinsByValue.Text);
                    result = SR1.dispenseMDBBillsByValue(intValue);
                }
                else
                {
                    result = 2;
                }
            }
            labelRtnDispenseMDBBillsByValue.Text = Convert.ToString(result);
        }

        private void buttonPollMDBBillPayout_Click(object sender, EventArgs e)
        {
            byte[] RxByte = new byte[1];            // array to hold receive data
            int RxSize = 0;
            // clear previous display
            labelPollMDBBillPayoutString.Text = "";
            int result = SR1.pollMDBBillPayout(ref RxByte, ref RxSize);
            labelRtnPollMDBBillPayout.Text = Convert.ToString(result);
            if (result == 0)
            {
                string displayString = null;
                if (RxSize == 0)
                {
                    displayString = "Ack";
                }
                else
                {
                    if (labelBillScale.Text == "0")
                    {
                        displayString = "???";
                    }
                    else
                    {
                        displayString = ConvertToCurrencyString(RxByte[0] * 256 + RxByte[1], Convert.ToInt32(labelBillScale.Text), Convert.ToByte(labelBillDecimal.Text));
                    }
                }
                labelPollMDBBillPayoutString.Text = displayString;
            }

        }

        private void buttonCancelMDBBillPayout_Click(object sender, EventArgs e)
        {
            int result = SR1.cancelMDBBillPayout();
            labelRtnCancelMDBBillPayout.Text = Convert.ToString(result);
        }

        private void buttonFeedWatchDog_Click(object sender, EventArgs e)
        {
            int result = SR1.feedWatchDog();
            labelRtnFeedWatchDog.Text = Convert.ToString(result);
        }

        private void buttonSetWatchDog_Click(object sender, EventArgs e)
        {
            int Expire = (int)numericUpDownWatchDogExpire.Value;    // WatchDog expires if it is not fed sooner
            int Reboot = (int)numericUpDownWatchDogReboot.Value;    // Reboot timer expires if system not reboots and feeds WatchDog sooner
            byte Relay = (byte)numericUpDownWatchDogReset.Value;    // Reset PC relay contact timer
            int result = SR1.setWatchDogTimer(Expire, Reboot, Relay);
            labelRtnSetWatchDog.Text = Convert.ToString(result);
        }

        private void timerAutoFeed_Tick(object sender, EventArgs e)
        {
            if (checkBoxAutoFeed.Checked == true) buttonFeedWatchDog_Click(sender, e);
        }

        private void checkBoxAutoFeed_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAutoFeed.Checked == true)
            {
                timerAutoFeed.Enabled = true;
            }
            else
            {
                timerAutoFeed.Enabled = false;
            }
        }

        private void radioButtonRelayOn_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonRelayOn.Checked == true)
            {
                int result = SR1.setRelayContact(1);
                labelRtnSetRelayContact.Text = Convert.ToString(result);
            }
        }

        private void radioButtonRelayOff_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonRelayOff.Checked == true)
            {
                int result = SR1.setRelayContact(0);
                labelRtnSetRelayContact.Text = Convert.ToString(result);
            }
        }
    }
}