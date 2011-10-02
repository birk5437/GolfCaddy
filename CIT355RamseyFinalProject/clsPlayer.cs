using System;
using System.Collections.Generic;
using System.Text;

namespace CIT355RamseyFinalProject
{
    public class clsPlayer
    {
        public int[] score;
        public string name;

        public clsPlayer(string playerName)
        {
            name = playerName;
            score = new int[18];
        }
    }
}
