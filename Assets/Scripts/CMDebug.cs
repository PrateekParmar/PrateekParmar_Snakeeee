using System;
using UnityEngine;
using Prateek.Utils;

namespace Prateek
{
    
    public static class CMDebug
    {

        
        public static World_Sprite Button(Transform parent, Vector3 localPosition, string text, System.Action ClickFunc, int fontSize = 30, float paddingX = 5, float paddingY = 5)
        {
            return World_Sprite.CreateDebugButton(parent, localPosition, text, ClickFunc, fontSize, paddingX, paddingY);
        }

        
        public static UI_Sprite ButtonUI(Vector2 anchoredPosition, string text, Action ClickFunc)
        {
            return UI_Sprite.CreateDebugButton(anchoredPosition, text, ClickFunc);
        }

        
        public static void TextPopupMouse(string text)
        {
            UtilsClass.CreateWorldTextPopup(text, UtilsClass.GetMouseWorldPositionZeroZ());
        }

       
        public static void TextPopup(string text, Vector3 position)
        {
            UtilsClass.CreateWorldTextPopup(text, position);
        }

        
        public static FunctionUpdater TextUpdater(Func<string> GetTextFunc, Vector3 localPosition, Transform parent = null)
        {
            return UtilsClass.CreateWorldTextUpdater(GetTextFunc, localPosition, parent);
        }

        
        public static FunctionUpdater TextUpdaterUI(Func<string> GetTextFunc, Vector2 anchoredPosition)
        {
            return UtilsClass.CreateUITextUpdater(GetTextFunc, anchoredPosition);
        }

        
        public static void MouseTextUpdater(Func<string> GetTextFunc, Vector3 positionOffset)
        {
            GameObject gameObject = new GameObject();
            FunctionUpdater.Create(() => {
                gameObject.transform.position = UtilsClass.GetMouseWorldPositionZeroZ() + positionOffset;
                return false;
            });
            TextUpdater(GetTextFunc, Vector3.zero, gameObject.transform);
        }

    }

}