﻿using System;
using System.Collections.Generic;
using System.Text;

namespace P1ClashOfRoyale
{
    class Enemic
    {
        // dos atributs que determinen la posició del minion
        private int row; // fila
        private int col; // columna

        public Enemic(int row, int col)
        {
            // definim la seva posició al crear un minion
            this.row = row;
            this.col = col;
        }
        public int getRow() { return row; }
        public int getCol() { return col; }

        public void print()
        {
            /* Implementació 11
             * imprimeix per pantalla una e a la posició col,row
             */
        }

        public void move()
        {
            /* Implementació 12
             * mou el miniom cap avall, 
             * o en direcció a un pont, 
             * o en direcció a la torre del mig
             */

        }

    }
}
