using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_chess
{
    public class Figure
    {
        public FigureType Type { get; set; }

        public Figure()
        {
            
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
