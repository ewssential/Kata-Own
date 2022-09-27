import pytest


class Cell:

    def __init__(self):
        pass

    def is_alive(self, neighbours):
        if neighbours > 1:
            return True
        return False


@pytest.fixture
def cell():
    return Cell()


def test_cell_with_fewer_than_two_neighbours_dies(cell):
    assert cell.is_alive(1) is False


def test_cell_with_three_neighbours_will_be_alive(cell):
    assert cell.is_alive(3) is True


def test_cell_with_two_neighbours_will_be_alive(cell):
    assert cell.is_alive(2) is True



