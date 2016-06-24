﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_MidTermExam
{
    /**
     * <summary>
     * This abstract class is a blueprint for all Lotto Games
     * </summary>
     * 
     * @class LottoGame
     * @property {int} ElementNum;
     * @property {int} SetSize;
     */
    public abstract class LottoGame
    {
        // PRIVATE INSTANCE VARIABLES +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


        // CREATE private fields here --------------------------------------------
        private List<int> _elementList;
        private List<int> _numberList;
        private int _elementNumber;
        private int _setSize;
        private Random _random = new Random(Guid.NewGuid().GetHashCode());
        // PUBLIC PROPERTIES ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public int ElementList
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public int ElementNumber
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public int NumberList
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public int Random
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public int SetSize
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        // CREATE public properties here -----------------------------------------

            // CONSTRUCTORS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            /**
             * <summary>
             * This constructor takes two parameters: elementNumber and setSize
             * The elementNumber parameter has a default value of 6
             * The setSize parameter has a default value of 49
             * </summary>
             * 
             * @constructor LottoGame
             * @param {int} elementNumber
             * @param {int} setSize
             */
        public LottoGame(int elementNumber = 6, int setSize = 49)
        {
            // assign elementNumber local variable to the ElementNumber property
            this.ElementNumber = elementNumber;

            // assign setSize local variable tot he SetSize property
            this.SetSize = setSize;

            // call the _initialize method
            this._initialize();

            // call the _build method
            this._build();
        }

        

        // PRIVATE METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        // CREATE the private _initialize method here -----------------------------

        // CREATE the private _build method here -----------------------------------

        // OVERRIDEN METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
         * <summary>
         * Override the default ToString function so that it displays the current
         * ElementList
         * </summary>
         * 
         * @override
         * @method ToString
         * @returns {string}
         */
        public override string ToString()
        {
            // create a string variable named lottoNumberString and intialize it with the empty string
            string lottoNumberString = String.Empty;

            // for each lottoNumber in ElementList, loop...
            foreach (int lottoNumber in ElementList)
            {
                // add lottoNumber and appropriate spaces to the lottoNumberString variable
                lottoNumberString += lottoNumber > 9 ? (lottoNumber + " ") : (lottoNumber + "  ");
            }

            return lottoNumberString;
        }

        private void _build()
        {
            throw new System.NotImplementedException();
        }

        private void _initialize()
        {
            throw new System.NotImplementedException();
        }

        public void PickElement()
        {
            throw new System.NotImplementedException();
        }

        // PUBLIC METHODS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        // CREATE the public PickElements method here ----------------------------
    }
}
