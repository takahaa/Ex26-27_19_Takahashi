using InputUtilitys;
namespace Ex26_19_Takahashi
{
    internal class Program1
    {
        static void Main(string[] args)
        {
            Cylinder cylinder = new Cylinder(
                InputUtility.InputFloat("���a"),
                InputUtility.InputFloat("����"));

            /*
             * �ʃo�[�W����
            var width = InputUtility.InputFloat("��");
            var height = InputUtility.InputFloat("����");
            var depth = InputUtility.InputFloat("���s");
            Box box = new Box(width, height, depth);
            */

            Console.WriteLine($"Box�̕\�ʐ�={cylinder.GetSurface()}\nBox�̑̐�={cylinder.GetVlueme()}");

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
