using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_chess
{
    public class Figure
    {
        private List<string> numbers = new List<string>() { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        private string position;
        
        public FigureType Type { get; set; }
        public string Position
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {

                }
                else if (numbers.Contains(value.Substring(1,1)))
                {

                }
            }

            get => position;
        }

        public Figure()
        {
            Position = "A2";
        }
    }


    //výčtový datový typ - seznam hodnot 
    public enum FigureType
    {
        Pawn,   //pěšec
        Rook,   //věž
        Knight, //jezdec
        Bishop, //střelec
        Queen,  //dáma
        King,   //král
    }
}
