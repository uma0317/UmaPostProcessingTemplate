using UnityEngine;

namespace Uma
{
    [ExecuteInEditMode]
    [RequireComponent(typeof(Camera))]
    [AddComponentMenu("Uma Image Effects/Project Name")]
    public class ProjectName : MonoBehaviour
    {
        #region Public Properties
        [SerializeField, Range(0, 3)]
        int _mode = 0;

        public int mode
        {
            get { return _mode; }
            set { _mode = value; }
        }
        #endregion

        #region Private Properties
        [SerializeField] Shader _shader;
        Material _material;
        #endregion

        #region MonoBehaviour Functions
        private void OnRenderImage(RenderTexture source, RenderTexture destination)
        {
            if (_material == null)
            {
                _material = new Material(_shader);
                _material.hideFlags = HideFlags.DontSave;
            }
            Graphics.Blit(source, destination, _material);
        }
        #endregion
    }
}