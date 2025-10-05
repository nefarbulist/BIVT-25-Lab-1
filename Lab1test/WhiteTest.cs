namespace Lab1
{
    public class White
    {
        public bool Task1(double d)
        {
            bool answer = false;

            // code here
            answer = d > 0;
            // end

            return answer;
        }

        public bool Task2(int n)
        {
            bool answer = false;

            // code here
            answer = n % 2 == 0;
            // end

            return answer;
        }

        public int Task3(int a, int b)
        {
            int answer = 0;

            // code here
            answer = (Math.Abs(a) > Math.Abs(b)) ? a : b;
            // end

            return answer;
        }

        public double Task4(double d, double f)
        {
            double answer = 0;

            // code here
            answer = (Math.Abs(d) < Math.Abs(f)) ? d : f;
            // end

            return answer;
        }

        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if (Math.Abs(x) > 1)
                answer = 1;
            else
                answer = x;
            // end

            return answer;
        }

        public bool Task6(double x, double y, double r)
        {
            bool answer = false;

            // code here
            answer = Math.Abs(x * x + y * y - r * r) <= 1e-4;
            // end

            return answer;
        }

        public bool Task7(int n)
        {
            bool answer = false;

            // code here
            answer = n % 22 == 0;
            // end

            return answer;
        }

        public bool Task8(double L, int T, int M)
        {
            bool answer = false;

            // code here
            answer = (L == 10 && T == 5 && M == 2) || (L == 30 && T == 3 && M == 4);
            // end

            return answer;
        }
    }
}
