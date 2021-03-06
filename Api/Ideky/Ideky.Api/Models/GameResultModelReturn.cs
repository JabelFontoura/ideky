﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ideky.Api.Models
{
    public class GameResultModelReturn
    {
        public int Id { get; set; }
        public DateTime GameDate { get; set; }
        public long FacebookID { get; set; }
        public int Score { get; set; }

        public GameResultModelReturn() { }
        public GameResultModelReturn(int id, long facebookId, int score, DateTime gameDate)
        {
            Id = id;
            FacebookID = facebookId;
            Score = score;
            GameDate = gameDate;
        }
    }
}