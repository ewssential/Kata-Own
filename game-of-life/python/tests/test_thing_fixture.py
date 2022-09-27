import pytest
class Cell:

    def __init__(self):
        pass

    def is_alive(self, neighbours):
        return False


@pytest.fixture
def cell():
    return Cell()


def test_cell_with_fewer_than_two_neighbours_dies(cell):
    assert cell.is_alive(1) is False



