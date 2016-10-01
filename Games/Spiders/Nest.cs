// Generated by Creer at 03:31AM on April 24, 2016 UTC, git hash: '087b1901032ab5bed5806b24830233eac5c2de55'
// A location (node) connected to other Nests via Webs (edges) in the game that Spiders can converge on, regardless of owner.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// <<-- Creer-Merge: usings -->> - Code you add between this comment and the end comment will be preserved between Creer re-runs.
// you can add addtional using(s) here
// <<-- /Creer-Merge: usings -->>

namespace Joueur.cs.Games.Spiders
{
    /// <summary>
    /// A location (node) connected to other Nests via Webs (edges) in the game that Spiders can converge on, regardless of owner.
    /// </summary>
    class Nest : Spiders.GameObject
    {
        #region Properties
        /// <summary>
        /// All the Spiders currently located on this Nest.
        /// </summary>
        public IList<Spiders.Spider> Spiders { get; protected set; }

        /// <summary>
        /// Webs that connect to this Nest.
        /// </summary>
        public IList<Spiders.Web> Webs { get; protected set; }

        /// <summary>
        /// The X coordinate of the Nest. Used for distance calculations.
        /// </summary>
        public int X { get; protected set; }

        /// <summary>
        /// The Y coordinate of the Nest. Used for distance calculations.
        /// </summary>
        public int Y { get; protected set; }


        // <<-- Creer-Merge: properties -->> - Code you add between this comment and the end comment will be preserved between Creer re-runs.
        // you can add addtional properties(s) here. None of them will be tracked or updated by the server.
        // <<-- /Creer-Merge: properties -->>
        #endregion


        #region Methods
        /// <summary>
        /// Creates a new instance of Nest. Used during game initialization, do not call directly.
        /// </summary>
        protected Nest() : base()
        {
            this.Spiders = new List<Spiders.Spider>();
            this.Webs = new List<Spiders.Web>();
        }


        // <<-- Creer-Merge: methods -->> - Code you add between this comment and the end comment will be preserved between Creer re-runs.

        /// <summary>
        /// Calculates the distance from this Nest to another Nest
        /// </summary>
        /// <param name="nest">The nest to calculate the distance to</param>
        /// <returns>The euclidean distance between the two Nests</returns>
        public double DistanceTo(Nest nest)
        {
            return Math.Sqrt( Math.Pow(nest.X - this.X, 2) + Math.Pow(nest.Y - this.Y, 2) );
        }

        // <<-- /Creer-Merge: methods -->>
        #endregion
    }
}