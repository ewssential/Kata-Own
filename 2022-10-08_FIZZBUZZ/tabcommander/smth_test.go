// You can edit this code!
// Click here and start typing.
package tabcommander

import "fmt"
import "testing"

func main() {
	fmt.Print(Hello())
}

func Hello() string {
	return "Hello, 世界"
}

func TestHello(t *testing.T) {
	got := Hello()
	want := "Hello, world"

	if got != want {
		t.Errorf("got %q want %q", got, want)
	}
}
