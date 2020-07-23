﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace TCOS_POC_DEMOAPP
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Verify_Welcome_Mesage recording.
    /// </summary>
    [TestModule("239e572e-8956-4e38-8fcb-13c3526539fc", ModuleType.Recording, 1)]
    public partial class Verify_Welcome_Mesage : ITestModule
    {
        /// <summary>
        /// Holds an instance of the TCOS_POC_DEMOAPPRepository repository.
        /// </summary>
        public static TCOS_POC_DEMOAPPRepository repo = TCOS_POC_DEMOAPPRepository.Instance;

        static Verify_Welcome_Mesage instance = new Verify_Welcome_Mesage();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Verify_Welcome_Mesage()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Verify_Welcome_Mesage Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RxMainFrame.RxTabIntroduction.EnterYourName' at 20;18.", repo.RxMainFrame.RxTabIntroduction.EnterYourNameInfo, new RecordItemIndex(0));
            repo.RxMainFrame.RxTabIntroduction.EnterYourName.Click("20;18");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'karthik' with focus on 'RxMainFrame.RxTabIntroduction.EnterYourName'.", repo.RxMainFrame.RxTabIntroduction.EnterYourNameInfo, new RecordItemIndex(1));
            repo.RxMainFrame.RxTabIntroduction.EnterYourName.PressKeys("karthik");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RxMainFrame.RxTabIntroduction.BtnSubmitUserName' at 22;15.", repo.RxMainFrame.RxTabIntroduction.BtnSubmitUserNameInfo, new RecordItemIndex(2));
            repo.RxMainFrame.RxTabIntroduction.BtnSubmitUserName.Click("22;15");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
