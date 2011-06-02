using System;
using System.Drawing;
using System.Windows.Forms;


namespace RabiShot.SSType {
    /// <summary>
    /// ��ʑS�̗̂̈���擾����N���X�B
    /// </summary>
    public class DisplayAll : IType {
        /// <summary>
        /// �X�N���[���V���b�g��ۑ�����̈���擾����B
        /// </summary>
        /// <returns>�X�N���[���V���b�g��ۑ�����̈�</returns>
        public Rectangle GetRectangle() {
            int x = 0, y = 0, width = 0, height = 0;

            foreach(var screen in Screen.AllScreens) {
                if(x > screen.Bounds.X)
                    x = screen.Bounds.X;
                if(y > screen.Bounds.Y)
                    y = screen.Bounds.Y;
                if(screen.Bounds.X == 0 && screen.Bounds.Y == 0) {
                    width += screen.Bounds.Width;
                    height += screen.Bounds.Height;
                } else {
                    width += Math.Abs(screen.Bounds.X);
                    height += Math.Abs(screen.Bounds.Y);
                }
            }

            return new Rectangle(x, y, width, height);
        }


    }
}