#region using
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media; 
#endregion

namespace Mundo3.SetRec
{
    public class Camera
    {
        #region private
        Matrix view;
        Matrix projection;
        Vector3 position;
        Vector3 target;
        Vector3 up; 
        #endregion

        public static Camera instance;

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static Camera GetInstance()
        {
            if (instance == null)
                instance = new Camera();

            return instance;
        }

        public Camera()
        {
            this.position = Vector3.Zero;
            this.target = Vector3.Zero;
            up = Vector3.Up;
            SetupView(position, target, up);

            SetupProjection();
        }

        public void SetCameraPosition(Vector3 position)
        {
            this.position = position;
            up = Vector3.Up;

            SetupView(position, target, up);
            SetupProjection();
        }

        public void SetCameraTarget(Vector3 target)
        {
            this.target = target;

            SetupView(position, target, up);
            SetupProjection();
        }

        public void SetupView(Vector3 position, Vector3 target, Vector3 up)
        {
            view = Matrix.CreateLookAt(position, target, up);
        }

        public void SetupProjection()
        {
            Screen telao = Screen.GetInstance();

            projection = Matrix.CreatePerspectiveFieldOfView(
                MathHelper.PiOver4,
                telao.GetWidth() / (float)telao.GetHeight(),
                0.0001f,
                10000);
        }

        public Matrix GetView()
        {
            return view;
        }

        public Matrix GetProjection()
        {
            return projection;
        }

        public void CameraFollow(Vector3 target)
        {
            SetCameraTarget(target);
        }
    }
}
