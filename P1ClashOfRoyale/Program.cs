using System;
using System.Collections.Generic;
using System.Threading;

namespace P1ClashOfRoyale
{
    class Program
    {
        private static List<Torre> torresEnemigues;
        private static List<Torre> myTowers;
        private static List<Enemic> enemics;
        private static List<Minion> myMinions;
        private static Random random = new Random();

        static void Main()
        {
            Console.WriteLine("Hello World!");
            init();
            print();
            while ( ! finish() )
            {
                createEnemic();
                update(); 
                print();
                Thread.Sleep(700);//miliseconds
                if (Console.KeyAvailable)
                    userInput();
            }
        }

        private static void init()
        {
            /* Implementació 5  - Passos 1-6
             * Crea les 6 torres dins dels corresponents llistats
             */

            /* Implementació 9 - Pas 1
             * Instancia la llista buida myMinions
             */


            /* Implementació 13 - Pas 1
             * Instancia la llista buida enemics
             */

        }

        private static bool finish()
        {
            /*
             * implementació 6
             * Si una de les dues llistes de torres és buida, 
             * s'acaba el joc.
             */
            return false;
        }

        private static void print()
        {
            Arena.print();

            /* Implementació 5 - Passos 7-8
             * mostra les torres, necessitaràs un bucle per cada llista
             */

            /* Implementació 9 - Pas 2
             * mostra els minions, fes un bucle que cridi el mètode print de cada objecte.
             */

            /* Implementació 13 - Pas 2
             * mostra els enemics, fes un bucle que cridi el mètode print de cada objecte.
             */


            Console.SetCursorPosition(Arena.nCol, Arena.nRow);
            Console.WriteLine("Tria una posició per inserir un nou minion, per exemple 9,2");
        }
        private static void userInput()
        {
            /* Implementació 10
             * Llegir l'entrada de la consola,
             * comprovem que sigui correcte
             * creem un minion i el inserim al llistat
             */
        }

        private static void createEnemic()
        {
            /* Implementació 14
             * Simulem que llancem un dau de 6 cares utilitzant el mètode Next:
             * public virtual int Next (int minValue, int maxValue);
             * minValue està inclòs
             * maxValue està exclòs
             * 
             * Si surt 1, crearem un enemic a una posició a l'atzar
             * assignem una posició de la part superior del tauler
             */

        }

        private static void update()
        {
            // primer actualitzem els enemics
            for (int n = 0; n < enemics.Count; n++)
            {
                bool remove = false;
                // movem els enemics
                Enemic e = enemics[n];
                e.move();
                // comprovem si la seva posició coincideix amb una torre
                int row = e.getRow();
                int col = e.getCol();
                for (int m = 0; m < myTowers.Count && remove == false; m++)
                {
                    Torre t = myTowers[m];
                    if (t.atac(row, col))
                    {
                        // eliminar enemic
                        remove = true;
                        // comprovar si eliminem torre
                        if (!t.isAlive())
                        {
                            myTowers.RemoveAt(m);
                            m--;
                        }
                    }
                }
                // comprovem si la seva posició coincideix amb un minion
                for (int m = 0; m < myMinions.Count && remove == false; m++)
                {
                    Minion unMinion = myMinions[m];
                    if (row == unMinion.getRow() && col == unMinion.getCol())
                    {
                        remove = true;
                        myMinions.RemoveAt(m);
                        m--;
                    }
                }
                if (remove)
                {
                    enemics.RemoveAt(n);
                    n--;
                }

            }
            // ara actualitzem els minions
            for (int m = 0; m < myMinions.Count; m++)
            {
                bool remove = false;
                Minion unMinion = myMinions[m];
                unMinion.move();

                // comprovem si la seva posició coincideix amb una torre
                int row = unMinion.getRow();
                int col = unMinion.getCol();
                for (int n = 0; n < torresEnemigues.Count && remove == false; n++)
                {
                    Torre t = torresEnemigues[n];
                    if (t.atac(row, col))
                    {
                        // eliminar minion
                        remove = true;
                        // comprovar si eliminem torre
                        if (!t.isAlive())
                        {
                            torresEnemigues.RemoveAt(n);
                            n--;
                        }
                    }
                }

                // comprovem si la seva posició coincideix amb un enemic
                for (int n = 0; n < enemics.Count && remove == false; n++)
                {
                    Enemic e = enemics[n];
                    if (row == e.getRow() && col == e.getCol())
                    {
                        remove = true;
                        enemics.RemoveAt(n);
                        n--;
                    }
                }
                if (remove)
                {
                    myMinions.RemoveAt(m);
                    m--;
                }
            }

        }


    }
}
