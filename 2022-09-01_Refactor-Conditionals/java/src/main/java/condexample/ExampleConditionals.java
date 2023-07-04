package condexample;

public class ExampleConditionals {

	static int invert(int x) {
		if (x != 3) {
			return 3;
		} else {
			return 4;
		}
	}

	static int redundant_else(int x) {
		if (x < 3) {
			return 1;
		} else if (x < 10) {
			return 10;
		}
		if (x < 30) {
			return 30;
		}
		return 0;
	}

	static boolean deMorgan(int x) {
		return !(x != 5 && x != 7);
	}

	static int join_AND(int x, int y) {
		if (x == 3) {
			if (y == 4) {
				return x + y;
			}
		}
		return 0;
	}

	static int split_AND(int x, int y) {
		if (x == 3 && y == 4) {
			return x + y;
		} else {
			return 0;
		}
	}

	static boolean join_OR(int x, int y) {
		if (x >= 0) {
			return true;
		}
		if (y <= 3) {
			return true;
		}
		return y == 10;
	}

	static boolean split_OR(int x, int y) {
		if (x >= 0 || y <= 3 || y == 10) {
			return true;
		}
		return false;
	}

	static int join_statements(int x, int y) {
		int result = 0;
		int factor = 1;
		if (x > 3) {
			factor = x;
		}
		if (x > 3) {
			result += y * 3;
		}
		return result * factor;
	}

	static int split_statements(int x, int y) {
		int result = 0;
		int factor = 1;
		if (x > 3) {
			result += y * 3;
			factor = x;
		}
		return result * factor;
	}

	static int normalize(String longss1, String s2) {
		if(longss1.equals("hello")) {
			if (s2.equals("bar")) {
				return 3;
			} else {
				return s2.equals("world") ? 5 : 4;
			}
		}
		if(s2.equals("world")) {
			if (longss1.equals("foo")) {
				return 0;
			}
			return 2;
		}
		else {
			if (longss1.equals("foo")) {
				return 1;
			}
			return 6;
		}
	}

}
