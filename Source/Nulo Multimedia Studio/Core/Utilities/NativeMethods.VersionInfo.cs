namespace Nulo.Core.Utilities {

    internal static partial class NativeMethods {

        public static string GetCopyright() {
            try {
                var info = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location);
                return info.LegalCopyright;
            } catch {
                return string.Empty;
            }
        }

        public static string GetSmallVersion() {
            try {
                var info = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location);
                return $"{info.ProductMajorPart}.{info.ProductMinorPart}";
            } catch {
                return string.Empty;
            }
        }

        public static string GetProductName() {
            try {
                var info = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location);
                return info.ProductName.Replace(" ®", "®");
            } catch {
                return string.Empty;
            }
        }

        public static string GetIdProduct() {
            return "{e4ef5f49-81d8-4933-b491-e81ae84f9bd6}";
        }
    }
}