using System.Drawing;


namespace RabiShot.SSType {
    /// <summary>
    /// ���R�ȗ̈���擾����B
    /// </summary>
    /// <remarks>
    /// ���R�ȗ̈���w�肷��E�B���h�E��\�����Ă���B
    /// </remarks>
    public class FreeArea : IType {
        /// <summary>
        /// ��ʑS�̗̂̈���擾����N���X��ێ�����B
        /// </summary>
        private static readonly IType All = new DisplayAll();

        /// <summary>
        /// �X�N���[���V���b�g��ۑ�����̈���擾����B
        /// </summary>
        /// <returns>�X�N���[���V���b�g��ۑ�����̈�</returns>
        public Rectangle GetRectangle() {
            // �͈͎w��p�t�H�[����\�������邽�߁A��ʑS�̂̑傫����\��
            // Rectangle���擾���Ă���
            using(var w = new FreeAreaForm(All.GetRectangle())) {
                w.ShowDialog();
                return w.GetSelectedRectangle();
            }
        }
    }
}