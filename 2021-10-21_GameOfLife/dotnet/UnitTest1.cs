using System;
using System.Numerics;
using Xunit;

namespace dotnet
{
    public class UnitTest1
    {
        /* RULES
        * A living cell with less than two neighbors: dies!
        * A living cell with two or three neighbors: survives!
        * A living cell with more than three neighbors: dies!
        * A dead cell with exactly three neighbors: become alive!
        */

        [Fact]
        public void BoardIsInitialized()
        {
            var gol = new GameOfLife(4);
            Assert.Equal(4*4, gol.Map.Length);
        }

        [Fact]
        public void FirstFieldIsAlive_NoNeighborsAlive_CellIsDead()
        {
            var board = new GameOfLife(4);
            var map = board.Map;
            map[0,0] = true;

            board.Next();
            Assert.False(map[0,0]);
        }

        [Fact]
        public void FirstFieldIsAlive_OneNeighborsAlive_CellIsDead()
        {
            var board = new GameOfLife(4);
            var map = board.Map;
            map[0,0] = true;
            map[0,1] = true;

            board.Next();
            Assert.False(map[0,0]);
        }

        [Fact]
        public void FirstFieldIsAlive_TwoNeighborsAlive_CellIsAlive()
        {
            var board = new GameOfLife(4);
            var map = board.Map;
            map[0,0] = true;
            map[0,1] = true;
            map[1,1] = true;

            board.Next();
            Assert.True(map[0,0]);
        }
    }

    internal class GameOfLife
    {
        public bool[,] Map;

        public GameOfLife(int v)
        {
            Map = new bool[v,v];
        }

        internal void Next()
        {
            Map[0,0] = false;
        }
    }
}
