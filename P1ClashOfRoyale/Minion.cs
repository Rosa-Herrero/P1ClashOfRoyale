using System;
using System.Collections.Generic;
using System.Text;

namespace P1ClashOfRoyale
{
    class Minion
    {
        // dos atributs que determinen la posició del minion
        private int row; // fila
        private int col; // columna

        public Minion(int row, int col)
        {
            // definim la seva posició al crear un minion
            this.row = row;
            this.col = col;
        }
        public int getRow() { return row; }
        public int getCol() { return col; }

        public void print()
        {
            /* Implementació 7
             * imprimeix per pantalla una m a la posició col,row
             */
        }

        public void move()
        {
            /* Implementació 8
             * mou el miniom cap amunt, 
             * o en direcció a un pont, 
             * o en direcció a la torre del mig
             */

        }

    }
}
