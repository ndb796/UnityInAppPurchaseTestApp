#if UNITY_ANDROID || UNITY_IPHONE || UNITY_STANDALONE_OSX || UNITY_TVOS
// WARNING: Do not modify! Generated file.

namespace UnityEngine.Purchasing.Security {
    public class AppleTangle
    {
        private static byte[] data = System.Convert.FromBase64String("6szo+v+p+P/v8b2MjJCZ3K6Tk4h+/fz69dZ6tHoLn5j5/cx9DszW+oXcnY+PiZGZj9ydn5+ZjIidkp+ZPJ/PiwvG+9CqFybz3fImRo/ls0k15Y4JofIpg6NnDtn/RqlzsaHxDa6ZkJWdkp+Z3JOS3IiUlY/cn5mO9Nf6/fn5+/796uKUiIiMj8bT04u1JIpjz+iZXYtoNdH+//38/V9+/XfldSIFt5AJ+1fezP4U5MIErPUvyc7NyMzPyqbr8c/JzM7Mxc7NyMzcnZKY3J+ZjoiVmpWfnYiVk5LcjJWalZ+diJWTkty9iYiUk46ViIXN08x9P/r01/r9+fn7/v7MfUrmfU9pYobwWLt3pyjqy883OPOxMuiVLZjJ3+m36aXhT2gLCmBiM6xGPaSsm3P0SNwLN1DQ3JOMSsP9zHBLvzPx+vXWerR6C/H9/fn5/P9+/f38oIO9VGQFLTaaYNiX7SxfRxjn1j/juYLjsJesar11OIie9+x/vXvPdn186NcslbtoivUCCJdx0rxaC7uxg1Qggt7JNtkpJfMqlyhe2N/tC11Q+Prv/qmvze/M7fr/qfj27/a9jIxCCI9nEi6Y8zeFs8gkXsIFhAOXNJ6QmdyPiJ2SmJ2OmNyImY6Rj9ydJcqDPXupJVtlRc6+ByQpjWKCXa76/6nh8vjq+OjXLJW7aIr1AgiXcYiVmpWfnYiZ3J6F3J2ShdyMnY6ITcykEKb4znCUT3PhIpmPA5uimUD5/P9+/fP8zH799v5+/f38GG1V9ZKY3J+TkpiViJWTko/ck5rciY+Z1nq0egvx/f35+fzMns33zPX6/6nKZbDRhEsRcGcgD4tnDooui8yzPY6dn4iVn5ncj4idiJmRmZKIj9LMiJSTjpWIhc3qzOj6/6n4/+/xvYz7EIHFf3ev3C/EOE1DZrP2lwPXAJCZ3LWSn9LN2szY+v+p+Pfv4b2M3JOa3IiUmdyIlJmS3J2MjJCVn53MfvhHzH7/X1z//v3+/v3+zPH69dgeFy1LjCPzuR3bNg2RhBEbSevr0NyfmY6IlZqVn52ImdyMk5CVn4XM7fr/qfj27/a9jIyQmdy1kp/SzUnGUQjz8vxu903d6tKIKcDxJ57qpVv59YDrvKrt4ogvS3ffx7tfKZPjeX9552XBu8sOVWe8ctAoTWzuJNy/vcx+/d7M8fr11nq0egvx/f390rxaC7uxg/SizOP6/6nh3/jkzOrB2pvcds+WC/F+MyIXX9MFr5anmPSizH797fr/qeHc+H799Mx+/fjMz8qmzJ7N98z1+v+p+Prv/qmvze9XX41uu6+pPVPTvU8EBx+MMRpfsONtJ+K7rBf5EaKFeNEXyl6rsKkQS+dBb77Y7tY78+FKsWCinzS3fOuGzH79iszy+v+p4fP9/QP4+P/+/YuL0p2MjJCZ0p+TkdOdjIyQmZ+d82HBD9e11OY0AjJJRfIlouAqN8H6zPP6/6nh7/39A/j5zP/9/QPM4YyQmdy/mY6IlZqVn52IlZOS3L2Jc499nDrnp/XTbk4EuLQMnMRi6QmMkJncrpOTiNy/vczi6/HMyszIztrM2Pr/qfj37+G9jIyQmdy/mY6IrFZ2KSYYACz1+8tMiYnd");
        private static int[] order = new int[] { 12,34,40,57,19,38,35,27,16,27,45,11,37,18,20,21,47,17,25,32,54,40,50,42,58,30,39,39,54,43,34,48,46,38,51,57,41,37,53,44,44,42,52,49,51,48,56,53,53,58,51,59,54,54,59,58,56,58,58,59,60 };
        private static int key = 252;

        public static readonly bool IsPopulated = true;

        public static byte[] Data() {
        	if (IsPopulated == false)
        		return null;
            return Obfuscator.DeObfuscate(data, order, key);
        }
    }
}
#endif
