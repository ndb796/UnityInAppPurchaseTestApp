#if UNITY_ANDROID || UNITY_IPHONE || UNITY_STANDALONE_OSX || UNITY_TVOS
// WARNING: Do not modify! Generated file.

namespace UnityEngine.Purchasing.Security {
    public class GooglePlayTangle
    {
        private static byte[] data = System.Convert.FromBase64String("mmORySJdhperIlkCkoVa9Lei26hNL7kJ2i7mL5AvcH4d/urTuHEYSuwkqJL22/iofCNn3Pit8nLkyu5Qstq+YdJTG4ltJDMu1AShuZCA70obZ4v6fHsYuCw1usdlosfWsua4QWnuesgtjbxVTeYdL8iafX0/IXDDvqfwE/qrtD6+Ft9e2YXKJHGBhNB0xkVmdElCTW7CDMKzSUVFRUFER3Q1RVaJlr++0+AvV4ehLq7BmrQJvX1yFUysHp0lBKabgqrSuMLFp8U2xzkHjm9fLY/331PviFy1SZNHicZFS0R0xkVORsZFRUTtOCLHzSkZr3xqZWYEuPnQGFvCESOBaq6BburU/PWD1AQtEQVvzOOOh2wT1/EWQ4xckal6t/c7oUZHRURF");
        private static int[] order = new int[] { 7,6,2,13,9,5,11,7,12,10,13,11,13,13,14 };
        private static int key = 68;

        public static readonly bool IsPopulated = true;

        public static byte[] Data() {
        	if (IsPopulated == false)
        		return null;
            return Obfuscator.DeObfuscate(data, order, key);
        }
    }
}
#endif
