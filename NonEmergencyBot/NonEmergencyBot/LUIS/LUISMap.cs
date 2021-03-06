﻿using System;

namespace NonEmergencyBot.LUIS
{
    [Serializable]
    public class LUISMap
    {
        public string Query { get; set; }
        public IntentType TopScoringIntent { get; set; }
        public IntentType[] Intents { get; set; }
        public EntityType[] Entities { get; set; }
    }

    [Serializable]
    public class IntentType
    {
        public Intents Intent { get; set; }
        public float Score { get; set; }
    }

    [Serializable]
    public class EntityType
    {
        public string Entity { get; set; }
        public Entities Type { get; set; }
        public int StartIndex { get; set; }
        public int EndIndex { get; set; }
        public float Score { get; set; }
    }
}