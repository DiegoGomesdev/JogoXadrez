﻿using System;
using Xadrex.tabuleiro;
using xadrez;
using Xadrez.tabuleiro;

namespace Xadrex
{
    class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez pos = new PosicaoXadrez('c', 7);


            Console.WriteLine(pos);


            Console.WriteLine(pos.toPosicao());





            Console.ReadLine();
        }
    }
}
