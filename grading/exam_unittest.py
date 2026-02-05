import unittest

def check_num(n):
    return n % 3 == 0 or n % 5 == 0


class TestCheckNum(unittest.TestCase):

    def test_three(self):
        self.assertTrue(check_num(6))

    def test_five(self):
        self.assertTrue(check_num(20))

    def test_three_and_five(self):
        self.assertTrue(check_num(30))

    def test_wrong(self):
        self.assertFalse(check_num(7))

    def test_zero(self):
        self.assertTrue(check_num(0))


if __name__ == "__main__":
    unittest.main()
