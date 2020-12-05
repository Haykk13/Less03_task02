namespace Less03_task02
{
	class Program
	{
		static void Main(string[] args)
		{
			new Derived(1, 2, 3);
		}
	}

	class Base
	{
		public int x;
		public int y;
		public Base(int x, int y)
		{
			this.x = x;
			this.y = y;
		}
	}

	class Derived : Base
	{
		public int z;
		public Derived(int x, int y, int z) : base(x, y)
		{
			this.z = z;
		}
	}
}
