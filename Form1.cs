using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using org.drools.dotnet.compiler;
using org.drools.dotnet.rule;
using org.drools.dotnet;

namespace MinimalDroolsForm
{
    public partial class Form1 : Form
    {
        public WorkingMemory workingMemory = null;
        public RuleBase ruleBase = null;
        public org.drools.FactHandle _currentCust = null;
        public CustomerRecord workingObj = null;
        public CustomerRecord secondWorkingObj = null;
        public static Form1 _thisForm = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            _thisForm = this;
            debugOutput.Text +=  "\nLoading Rule Base: ";
            _thisForm.Refresh();
            PackageBuilder builder = new PackageBuilder();
            Stream stream = new FileStream(@"C:\Users\wangs153\Documents\workspace\Demo\MinimalDroolsForm\SimpleRulesExt.drl", FileMode.Open); 
            debugOutput.Text += "\nStream Set ";
            _thisForm.Refresh();
            debugOutput.Text += "\nReading DRL (Please wait... this may take a few moments...) ";
            _thisForm.Refresh(); 
            
            builder.AddPackageFromDrl("MinimalDroolsForm.SimpleRules.drl", stream);
            debugOutput.Text += "... Finished ";
            _thisForm.Refresh(); 
            Package pkg = builder.GetPackage();
            debugOutput.Text += "\nPackage Added ";
            _thisForm.Refresh();
            ruleBase = RuleBaseFactory.NewRuleBase();
            ruleBase.AddPackage(pkg);
            debugOutput.Text += "\nRule Base Set ";
            _thisForm.Refresh();
            workingMemory = ruleBase.NewWorkingMemory();
            workingObj = new CustomerRecord();
            secondWorkingObj = null;
           
        }

        //private void TestInteger(RuleBase ruleBase, int value, Form1 F1)
        //{
        //    F1.debugOutput.Text += "\nRule Run: ";

        //    if (_currentInt == null)
        //    {
        //        workingObj.Id = "NEW";
        //        workingObj.Status = "NORMAL";
        //        workingObj.Value = 5;
        //        workingObj.DaysSinceLastOrder = 0;
        //        _currentInt = F1.workingMemory.assertObject(workingObj);
        //    }
        //    else
        //    {
        //        workingObj.Id = "UPDATED";
        //        workingObj.DaysSinceLastOrder = 120;
        //        workingObj.Status = "Normal";
        //        workingObj.Value = value;
        //        F1.workingMemory.modifyObject(_currentInt, workingObj);
        //    }
        //    if (secondWorkingObj != null)
        //    {
        //        F1.workingMemory.assertObject(secondWorkingObj);
        //    }
        //    F1.workingMemory.fireAllRules();
        //    IntWrapper customer = (IntWrapper) F1.workingMemory.getObject(_currentInt);
        //    F1.debugOutput.Text += "\nCustomer: " + customer.Id + 
        //               " | Qty: " + customer.Value + " | STATUS: " + customer.Status;
            
        //}

        public static void debugResult(String str)
        {
            _thisForm.debugOutput.Text += "\nRULE FIRED: " + str;
            _thisForm.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int formQTY;
            int formDays;

            try { formQTY = Int32.Parse(qtyTextBox.Text); }
            catch { formQTY = 0; }
            try { formDays = Int32.Parse(DaysSinceTextBox.Text); }
            catch { formDays = 0; }

            workingObj.Id = IDTextBox.Text;
            workingObj.Status = StatusTextBox.Text;
            workingObj.Value = formQTY;
            workingObj.DaysSinceLastOrder = formDays;

            if (ScenarioButton3.Checked == true)
            {
                secondWorkingObj = new CustomerRecord();
                secondWorkingObj.Id = "111-111";
                secondWorkingObj.Status = "NORMAL";
                secondWorkingObj.Value = 5;
                secondWorkingObj.DaysSinceLastOrder = 95;
            }
            TestRules(ruleBase, _thisForm);
        }


        private void ScenarioButton1_CheckedChanged(object sender, EventArgs e)
        {
            qtyTextBox.Text = "5";
            IDTextBox.Text = "111-111";
            DaysSinceTextBox.Text = "15";
            StatusTextBox.Text = "NORMAL";
            _thisForm.Refresh();
            if (secondWorkingObj != null) secondWorkingObj = null;
        }

        private void ScenarioButton2_CheckedChanged(object sender, EventArgs e)
        {
            qtyTextBox.Text = "500";
            IDTextBox.Text = "222-222";
            DaysSinceTextBox.Text = "91";
            StatusTextBox.Text = "INACTIVE";
            _thisForm.Refresh();
            if (secondWorkingObj != null) secondWorkingObj = null;
        }

        private void ScenarioButton3_CheckedChanged(object sender, EventArgs e)
        {
            qtyTextBox.Text = "50";
            IDTextBox.Text = "333-333";
            DaysSinceTextBox.Text = "120";
            StatusTextBox.Text = "NORMAL";
            _thisForm.Refresh();
            debugOutput.Text += "\nNOTE: THIS SCENARIO INCLUDES AN ADDIONAL OBJECT";
        }

        //**********************************************************
        // workingObj is set by the button click method
        //**********************************************************
        private void TestRules(RuleBase ruleBase,  Form1 F1)
        {
            F1.debugOutput.Text += "\nRule Run: ";

            if (_currentCust == null)
            {
                _currentCust = F1.workingMemory.assertObject(workingObj);
            }
            else
            {
                F1.workingMemory.modifyObject(_currentCust, workingObj);
            }
            if (secondWorkingObj != null)
             {
                      F1.workingMemory.assertObject(secondWorkingObj);
             }
            F1.workingMemory.fireAllRules();
            CustomerRecord customer = (CustomerRecord)F1.workingMemory.getObject(_currentCust);
            F1.debugOutput.Text += "\nCustomer: " + customer.Id +
                       " | Qty: " + customer.Value + " | STATUS: " + customer.Status;
            if (secondWorkingObj != null)
            {
                F1.debugOutput.Text += "\n 2nd Customer: " + secondWorkingObj.Id +
                       " | Qty: " + secondWorkingObj.Value + " | STATUS: " + secondWorkingObj.Status;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            debugOutput.Text = "";
        }

    
    }
}
