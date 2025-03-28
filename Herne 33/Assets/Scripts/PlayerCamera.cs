using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using Unity.VisualScripting;

namespace GDIM33Demo
{
    [Inspectable]
    public class PlayerCamera : MonoBehaviour
    {
        //---------------------------------------------------------------------
        // Variables
        //---------------------------------------------------------------------
        [SerializeField] private int _numFilm;
        public Texture2D _recentPhoto;

        private Texture2D[] _activePhotos;
        private int _currentPhotoIndex;
        private bool _waitingForPhoto;

        //---------------------------------------------------------------------
        // Methods
        //---------------------------------------------------------------------
        private void Start ()
        {
            SetupFilm();
            RenderPipelineManager.endCameraRendering += OnEndCameraRendering;
        }

        //---------------------------------------------------------------------
        private void SetupFilm ()
        {
            int w = Screen.width;
            int h = Screen.height;
            _activePhotos = new Texture2D[_numFilm];
            for(int i = 0; i < _numFilm; i++)
            {
                Texture2D photo = new Texture2D(
                    w, h,
                    TextureFormat.RGB24,
                    0, false
                );
                _activePhotos[i] = photo;
            }
            _currentPhotoIndex = 0;
        }

        //---------------------------------------------------------------------
        public void TakePhoto ()
        {
            _waitingForPhoto = true;
        }

        //---------------------------------------------------------------------
        private void OnEndCameraRendering(
            ScriptableRenderContext context,
            Camera camera
        ) {
            if(!_waitingForPhoto || camera != Camera.main) 
            {
                return;
            }
            _waitingForPhoto = false;

            if(_currentPhotoIndex >= _activePhotos.Length)
            {
                return;
            }            

            // get current active film
            Texture2D photo = _activePhotos[_currentPhotoIndex];
            
            // take screenshot
            Rect regionToReadFrom = new Rect(0, 0, Screen.width, Screen.height);
            photo.ReadPixels(regionToReadFrom, 0, 0, false);
            photo.Apply(); // send to GPU

            _currentPhotoIndex++;

            // tell UI
            _recentPhoto = photo;
            EventBus.Trigger(EventNames.PhotoReadyEvent, 0);
        }

        //---------------------------------------------------------------------
        private void OnDestroy ()
        {
            RenderPipelineManager.endCameraRendering -= OnEndCameraRendering;
        }
    }
}