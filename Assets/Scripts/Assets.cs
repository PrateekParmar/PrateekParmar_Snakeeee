using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Prateek
{

   
    public class Assets : MonoBehaviour
    {

        
        private static Assets _i;
        private static Assets _b;


        public static Assets i
        {
            get
            {
                if (_i == null) _i = (Instantiate(Resources.Load("PrateekAssets")) as GameObject).GetComponent<Assets>();
                return _i;
            }
        }


        public static Assets b
        {
            get
            {
                if (_b == null) _b = (Instantiate(Resources.Load("PrateekAssets")) as GameObject).GetComponent<Assets>();
                return _b;
            }
        }

        public Sprite s_White;

    }

}
