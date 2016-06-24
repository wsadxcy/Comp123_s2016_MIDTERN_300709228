using System;
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


        // CREATE public properties here -----------------------------------------

        public List<int> ElementList
        {
            get
            {
                return this._elementList;
            }

            set
            {

            }
        }

        public int ElementNumber
        {
            get
            {
                return this._elementNumber;
            }

            set
            {
                this._elementNumber = value;
            }
        }

        public List<int> NumberList
        {
            get
            {
                return this._numberList;
            }

            set
            {
            }
        }

        public Random Random
        {
            get
            {
                return this._random;
            }

            set
            {
            }
        }

        public int SetSize
        {
            get
            {
                return this._setSize;
            }

            set
            {
                this._setSize = value;
            }
        }
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
        private void _initialize()
        {
            this._numberList = NumberList;
            this._elementList = ElementList;
            this._random = Random;
        }

        // CREATE the private _build method here -----------------------------------
        private void _build()
        {
            for (int maxnumber = 0; maxnumber < this.SetSize; maxnumber++)
            {
                this.NumberList Add(".");
            }
        }

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

        

        public void PickElement()
        {
           
        }

        // PUBLIC METHODS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


        // CREATE the public PickElements method here ----------------------------
    }
}
