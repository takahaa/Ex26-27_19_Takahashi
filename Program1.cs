using InputUtilitys;
namespace Ex26_19_Takahashi
{
    internal class Program1
    {
        static void Main(string[] args)
        {
            Cylinder cylinder = new Cylinder(
                InputUtility.InputFloat("半径"),
                InputUtility.InputFloat("高さ"));

            /*
             * 別バージョン
            var width = InputUtility.InputFloat("幅");
            var height = InputUtility.InputFloat("高さ");
            var depth = InputUtility.InputFloat("奥行");
            Box box = new Box(width, height, depth);
            */

            Console.WriteLine($"Boxの表面積={cylinder.GetSurface()}\nBoxの体積={cylinder.GetVlueme()}");

        }
    }

    class Cylinder
    {
        float radius;
        float height;

        public Cylinder(float radius, float height)
        {
            this.radius = radius;
            this.height = height;

        }

        public float GetSurface()
        {
            return radius * radius * (float)Math.PI * 2 + radius * 2 * (float)Math.PI * height ;
        }

        public float GetVlueme()
        {
            return radius * radius * (float)Math.PI * height;
        }
    }
}
