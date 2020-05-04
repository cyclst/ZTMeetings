﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.1.0.0
//      SpecFlow Generator Version:3.1.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace ZTMeetings.Api.Specs.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Bookings")]
    public partial class BookingsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "Bookings.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Bookings", "\tIn order to attend meetings\r\n\tAs a Zupa Tech Employee\r\n\tI want to be able to a b" +
                    "ook seats", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 6
#line hidden
#line 7
 testRunner.Given("there are no booked seats", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Book Single Seats With Full Seat Availability")]
        [NUnit.Framework.CategoryAttribute("mytag")]
        public virtual void BookSingleSeatsWithFullSeatAvailability()
        {
            string[] tagsOfScenario = new string[] {
                    "mytag"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Book Single Seats With Full Seat Availability", null, new string[] {
                        "mytag"});
#line 10
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 6
this.FeatureBackground();
#line hidden
                TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                            "Employee Name",
                            "Emplyee Email"});
                table1.AddRow(new string[] {
                            "Leonard Hofstadter",
                            "leonard@zupa.co.uk"});
#line 11
 testRunner.When("I book a seat for Employees", ((string)(null)), table1, "When ");
#line hidden
                TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                            "Seat Number",
                            "Employee Name",
                            "Emplyee Email"});
                table2.AddRow(new string[] {
                            "A1",
                            "Leonard Hofstadter",
                            "leonard@zupa.co.uk"});
#line 14
 testRunner.Then("the booked seats should be", ((string)(null)), table2, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Book Maximum Seats With Full Seat Availability")]
        public virtual void BookMaximumSeatsWithFullSeatAvailability()
        {
            string[] tagsOfScenario = ((string[])(null));
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Book Maximum Seats With Full Seat Availability", null, ((string[])(null)));
#line 18
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 6
this.FeatureBackground();
#line hidden
                TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                            "Employee Name",
                            "Emplyee Email"});
                table3.AddRow(new string[] {
                            "Leonard Hofstadter",
                            "leonard@zupa.co.uk"});
                table3.AddRow(new string[] {
                            "Sheldon Cooper",
                            "sheldon@zupa.co.uk"});
                table3.AddRow(new string[] {
                            "Penny Hofstadter",
                            "penny@zupa.co.uk"});
                table3.AddRow(new string[] {
                            "Howard Wolowitz",
                            "howard@zupa.co.uk"});
#line 19
 testRunner.When("I book a seat for Employees", ((string)(null)), table3, "When ");
#line hidden
                TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                            "Seat Number",
                            "Employee Name",
                            "Emplyee Email"});
                table4.AddRow(new string[] {
                            "A1",
                            "Leonard Hofstadter",
                            "leonard@zupa.co.uk"});
                table4.AddRow(new string[] {
                            "A2",
                            "Sheldon Cooper",
                            "sheldon@zupa.co.uk"});
                table4.AddRow(new string[] {
                            "A3",
                            "Penny Hofstadter",
                            "penny@zupa.co.uk"});
                table4.AddRow(new string[] {
                            "A4",
                            "Howard Wolowitz",
                            "howard@zupa.co.uk"});
#line 25
 testRunner.Then("the booked seats should be", ((string)(null)), table4, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Book Seats With First 3 Seats Already Booked")]
        public virtual void BookSeatsWithFirst3SeatsAlreadyBooked()
        {
            string[] tagsOfScenario = ((string[])(null));
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Book Seats With First 3 Seats Already Booked", null, ((string[])(null)));
#line 32
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 6
this.FeatureBackground();
#line hidden
#line 33
 testRunner.Given("3 Seats Have Been Booked By Employees", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                            "Employee Name",
                            "Emplyee Email"});
                table5.AddRow(new string[] {
                            "Raj Koothrappali",
                            "raj@zupa.co.uk"});
                table5.AddRow(new string[] {
                            "Bernadette Rostenkowski",
                            "bernadette@zupa.co.uk"});
                table5.AddRow(new string[] {
                            "Amy Farrah Fowler",
                            "amy@zupa.co.uk"});
#line 34
 testRunner.When("I book a seat for Employees", ((string)(null)), table5, "When ");
#line hidden
                TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                            "Seat Number",
                            "Employee Name",
                            "Emplyee Email"});
                table6.AddRow(new string[] {
                            "A1",
                            "Leonard Hofstadter",
                            "leonard@zupa.co.uk"});
                table6.AddRow(new string[] {
                            "A2",
                            "Sheldon Cooper",
                            "sheldon@zupa.co.uk"});
                table6.AddRow(new string[] {
                            "A3",
                            "Penny Hofstadter",
                            "penny@zupa.co.uk"});
                table6.AddRow(new string[] {
                            "A4",
                            "Howard Wolowitz",
                            "howard@zupa.co.uk"});
                table6.AddRow(new string[] {
                            "B1",
                            "Raj Koothrappali",
                            "raj@zupa.co.uk"});
                table6.AddRow(new string[] {
                            "B2",
                            "Bernadette Rostenkowski",
                            "bernadette@zupa.co.uk"});
                table6.AddRow(new string[] {
                            "B3",
                            "Amy Farrah Fowler",
                            "amy@zupa.co.uk"});
#line 39
 testRunner.Then("the booked seats should be", ((string)(null)), table6, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Book More Than The Maximum Number Of Seats")]
        public virtual void BookMoreThanTheMaximumNumberOfSeats()
        {
            string[] tagsOfScenario = ((string[])(null));
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Book More Than The Maximum Number Of Seats", null, ((string[])(null)));
#line 49
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 6
this.FeatureBackground();
#line hidden
                TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                            "Employee Name",
                            "Emplyee Email"});
                table7.AddRow(new string[] {
                            "Leonard Hofstadter",
                            "leonard@zupa.co.uk"});
                table7.AddRow(new string[] {
                            "Sheldon Cooper",
                            "sheldon@zupa.co.uk"});
                table7.AddRow(new string[] {
                            "Penny Hofstadter",
                            "penny@zupa.co.uk"});
                table7.AddRow(new string[] {
                            "Howard Wolowitz",
                            "howard@zupa.co.uk"});
                table7.AddRow(new string[] {
                            "Raj Koothrappali",
                            "raj@zupa.co.uk"});
#line 50
 testRunner.When("I book a seat for Employees", ((string)(null)), table7, "When ");
#line hidden
#line 57
 testRunner.Then("the following error should be returned \'The maximum number of seats that can be b" +
                        "ooked by an employee is 4\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Book More Seats Than Are Available")]
        public virtual void BookMoreSeatsThanAreAvailable()
        {
            string[] tagsOfScenario = ((string[])(null));
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Book More Seats Than Are Available", null, ((string[])(null)));
#line 59
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 6
this.FeatureBackground();
#line hidden
#line 60
 testRunner.Given("99 Seats Have Been Booked By Employees", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                            "Employee Name",
                            "Emplyee Email"});
                table8.AddRow(new string[] {
                            "Leonard Hofstadter",
                            "leonard@zupa.co.uk"});
                table8.AddRow(new string[] {
                            "Sheldon Cooper",
                            "sheldon@zupa.co.uk"});
#line 61
 testRunner.When("I book a seat for Employees", ((string)(null)), table8, "When ");
#line hidden
#line 65
 testRunner.Then("the following error should be returned \'Not enough seats available to book. Curre" +
                        "nt seat availability is 1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Book More Seats When Meeting Is Full")]
        public virtual void BookMoreSeatsWhenMeetingIsFull()
        {
            string[] tagsOfScenario = ((string[])(null));
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Book More Seats When Meeting Is Full", null, ((string[])(null)));
#line 67
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 6
this.FeatureBackground();
#line hidden
#line 68
 testRunner.Given("100 Seats Have Been Booked By Employees", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                            "Employee Name",
                            "Emplyee Email"});
                table9.AddRow(new string[] {
                            "Leonard Hofstadter",
                            "leonard@zupa.co.uk"});
#line 69
 testRunner.When("I book a seat for Employees", ((string)(null)), table9, "When ");
#line hidden
#line 72
 testRunner.Then("the following error should be returned \'Meeting is full\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Book A Seat For An Employee Multiple Times")]
        public virtual void BookASeatForAnEmployeeMultipleTimes()
        {
            string[] tagsOfScenario = ((string[])(null));
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Book A Seat For An Employee Multiple Times", null, ((string[])(null)));
#line 74
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 6
this.FeatureBackground();
#line hidden
                TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                            "Employee Name",
                            "Emplyee Email"});
                table10.AddRow(new string[] {
                            "Leonard Hofstadter",
                            "leonard@zupa.co.uk"});
#line 75
 testRunner.Given("Seats have been booked for Employees", ((string)(null)), table10, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                            "Employee Name",
                            "Emplyee Email"});
                table11.AddRow(new string[] {
                            "Leonard Hofstadter",
                            "leonard@zupa.co.uk"});
                table11.AddRow(new string[] {
                            "Sheldon Cooper",
                            "sheldon@zupa.co.uk"});
#line 78
 testRunner.When("I book a seat for Employees", ((string)(null)), table11, "When ");
#line hidden
#line 82
 testRunner.Then("the following error should be returned \'The following employees already have seat" +
                        "s booked: Leonard Hofstadter\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
