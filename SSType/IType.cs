using System.Drawing;


namespace RabiShot.SSType {
    /// <summary>
    /// �X�N���[���V���b�g�̎�ނ��`����C���^�[�t�F�[�X�B
    /// </summary>
    public interface IType {
        /// <summary>
        /// �X�N���[���V���b�g��ۑ�����̈���擾����B
        /// </summary>
        /// <returns>�X�N���[���V���b�g��ۑ�����̈�</returns>
        Rectangle GetRectangle();
    }
}