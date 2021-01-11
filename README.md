# C# WinForm Virtual Keyboard

In this project, we make a virtual keyboard with C# Windows Form. Keyboard type is Qwerty.
Capslock, shift, ctrl and alt buttons choose as ChexBox. The appearance of these Checboxes should be set to button. CheckBox returns values of true or false.
Other buttons choose button structure.
You can adjust the size of buttons as you want.

Program algortihm works based on if statement structure.

 private void button37_Click(object sender, EventArgs e)
        {
            if (capslock.Checked || lshift.Checked || rshift.Checked)
            {
                SendKeys.Send("A");
                lshift.Checked = false;
                rshift.Checked = false;
            }

            else if (lctrl.Checked || rctrl.Checked)
            {
                SendKeys.Send("^{A}");
                lctrl.Checked = false;
                rctrl.Checked = false;
            }

            else
            {
                SendKeys.Send("a");
            }
        }

We can look at the codes above.
We can tell, SendKeys is a property.

If you want to send character "A" to screen, you must press to capslock or left, right shift buttons like on real keyboard.
Right and left shift buttons work one time therefore we get reset these buttons but caps lock is not so. If you want to close it should press second time.

On line 19 we look to a sticky button. In the SendKeys property, "^" sign defined as CTRL so this command means CTRL + A

And on line 26, if no conditions are met we use this block. We send character "a" to screen.

Source : https://www.youtube.com/watch?v=oEHXBlEfOvM&t=636s
