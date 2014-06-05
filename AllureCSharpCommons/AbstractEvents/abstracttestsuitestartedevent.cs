﻿using AllureCSharpCommons.AllureModel;
using AllureCSharpCommons.Events;

namespace AllureCSharpCommons.AbstractEvents
{
    public abstract class AbstractTestSuiteStartedEvent : ITestSuiteEvent
    {
        public string Uid { get; set; }

        public string Name { get; set; }

        public string Title { get; set; }

        public description Description { get; set; }

        public label[] Labels { get; set; }

        public abstract void Process(testsuiteresult context);
    }
}