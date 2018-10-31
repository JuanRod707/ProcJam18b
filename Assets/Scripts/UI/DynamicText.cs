using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    [RequireComponent(typeof(Text))]
    public class DynamicText : MonoBehaviour
    {
        public string Format;

        private Text myText;

        void Start()
        {
            myText = GetComponent<Text>();
        }

        public void SetValues(params object[] values) => myText.text = string.Format(Format, values);
    }
}
