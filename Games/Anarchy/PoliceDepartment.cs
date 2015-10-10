// Generated by Creer at 03:39AM on October 10, 2015 UTC, git hash: '98604e3773d1933864742cb78acbf6ea0b4ecd7b'
// Used to keep cities under control and raid Warehouses.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// <<-- Creer-Merge: usings -->> - Code you add between this comment and the end comment will be preserved between Creer re-runs.
// you can add addtional using(s) here
// <<-- /Creer-Merge: usings -->>

namespace Joueur.cs.Games.Anarchy
{
    /// <summary>
    /// Used to keep cities under control and raid Warehouses.
    /// </summary>
    class PoliceDepartment : Anarchy.Building
    {
        #region Properties

        // <<-- Creer-Merge: properties -->> - Code you add between this comment and the end comment will be preserved between Creer re-runs.
        // you can add addtional properties(s) here. None of them will be tracked or updated by the server.
        // <<-- /Creer-Merge: properties -->>
        #endregion


        #region Methods
        /// <summary>
        /// Creates a new instance of {$obj_key}. Used during game initialization, do not call directly.
        /// </summary>
        protected PoliceDepartment() : base()
        {
        }

        /// <summary>
        /// Bribe the police to raid a Warehouse, dealing damage equal based on the Warehouse's current exposure, and then resetting it to 0.
        /// </summary>
        /// <param name="warehouse">The warehouse you want to raid.</param>
        /// <returns>The amount of damage dealt to the warehouse, or -1 if there was an error.</returns>
        public int Raid(Anarchy.Warehouse warehouse)
        {
            return this.RunOnServer<int>("raid", new Dictionary<string, object> {
                {"warehouse", warehouse}
            });
        }

        // <<-- Creer-Merge: methods -->> - Code you add between this comment and the end comment will be preserved between Creer re-runs.
        // you can add addtional method(s) here.
        // <<-- /Creer-Merge: methods -->>
        #endregion
    }
}
