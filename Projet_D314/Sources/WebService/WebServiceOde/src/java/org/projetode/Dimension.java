/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package org.projetode;


/**
 *
 * @author olivier.essner
 */
public class Dimension
{
        // Membres
        private String dimensionName; // Nom de la dimension
        private long dimensionCount; // Nombre de lignes de la dimension
        private int dimensionMemory; // Taille d'une ligne, en octets
        private int dimensionOrder; // Indique la dimension du cuboide

        // Constructeur avec dimensionOrder comme argument
        Dimension(int inDimensionOrder)
        {
            SetDimensionName("");
            SetDimensionCount(1);
            SetDimensionMemory(0);
            this.dimensionOrder = inDimensionOrder;
        }

        // Constructeur avec (name, count, dimensionOrder) comme arguments
        Dimension(String inDimensionName, long inDimensionCount, int inDimensionOrder)
        {
            SetDimensionName(inDimensionName);
            SetDimensionCount(inDimensionCount);
            SetDimensionMemory(0);
            this.dimensionOrder = inDimensionOrder;
        }

        // Methodes
        public void SetDimensionName(String inDimensionName) { this.dimensionName = new String(inDimensionName); }
        public void SetDimensionCount(long inDimensionCount) { this.dimensionCount = inDimensionCount; }
        public void SetDimensionMemory(int inDimensionMemory) { this.dimensionMemory = inDimensionMemory; }
        // REM : Pas d'accesseur Set pour "dimensionOrder" car parametré à l'instanciation de classe

        public String GetDimensionName() { return (this.dimensionName); }
        public long GetDimensionCount() { return (this.dimensionCount); }
        public int GetDimensionMemory() { return (this.dimensionMemory); }
        public int GetDimensionOrder() { return (this.dimensionOrder); }
  }
