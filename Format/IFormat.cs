namespace RabiShot.Format {
    /// <summary>
    /// �t�H�[�}�b�g�̃C���^�[�t�F�[�X
    /// </summary>
    public interface IFormat {
        /// <summary>
        /// �t�H�[�}�b�g���當����𐶐�����B
        /// </summary>
        /// <param name="fmt">�t�H�[�}�b�g</param>
        /// <returns>��������������</returns>
        string Generate(string fmt);
    }
}