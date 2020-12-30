﻿using Fixie;

namespace NBAProject.Tests
{
    public class TestingConvetion : Discovery, Execution
    {
        public TestingConvetion()
        {
            Methods
                .Where(x => x.Name != "SetUp");
        }

        public void Execute(TestClass testClass)
        {
            var instance = testClass.Construct();

            SetUp(instance);

            testClass.RunCases(@case => { @case.Execute(instance); });

            instance.Dispose();
        }

        private static void SetUp(object instance)
        {
            instance.GetType().GetMethod("SetUp")?.Execute(instance);
        }
    }
}