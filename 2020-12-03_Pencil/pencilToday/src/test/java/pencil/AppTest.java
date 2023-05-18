package pencil;

import static org.junit.Assert.assertEquals;

import org.junit.Before;
import org.junit.Test;

/**
 * Unit test for simple App.
 */
public class AppTest {
    /**
     * Rigorous Test :-)
     */

     private Pencil pencil;

     @Before
     public void niceBeforeSetupper(){
        pencil = new Pencil();
     }

    @Test
    public void pencilShouldReturnValue() {
        assertEquals("Hello!", pencil.write("Hello!"));
    }

    @Test
    public void pecilShouldAppendMessageToWrittenMessage() {
        assertEquals("She sells sea shells", pencil.write("She sells sea shells"));
        assertEquals("She sells sea shells down by the sea shore", pencil.write(" down by the sea shore"));
    }

    @Test
    public void pecilShouldGoDullAfter2LettersWith3Letters() {
        assertEquals("ab ", pencil.write("abc"));
    }

    private class Pencil {
        private String Message = "";

        public String write(String message) {
            Message += message;
            return Message;
        }
    }
}
