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
using Mundo3.SetRec;
using Mundo3.Objects;
#endregion

namespace Mundo3.Manager
{
    static class SceneManager
    {
        #region private
        static List<Scene> scenes;
        static Scene actualScene;
        static Screen screen;
        static Camera camera;
        static Chopper chooper;
        #endregion

        #region public
        public static ContentManager staticContent;
        public static GraphicsDevice staticDevice;
        public static Effect staticEffect;
        #endregion

        public static void Initialize(GraphicsDevice device, ContentManager content, int screenWidth, int screenHeight)
        {
            staticDevice = device;
            staticContent = content;

            screen = Screen.GetInstance();
            screen.SetWidth(screenWidth);
            screen.SetHeight(screenHeight);

            camera = Camera.GetInstance();
            camera.SetCameraPosition(new Vector3(18.5f, 3.5f, 6));
            camera.SetCameraTarget(Vector3.Zero);

            staticEffect = staticContent.Load<Effect>(@"Effect\effect1");
        }

        public static void LoadContent(ContentManager content)
        {
            //TODO: Create Objects to include on set
            chooper = new Chopper(@"Texture\camo");
            #region set do helicoptero
            List<Quad> heliBody = new List<Quad> 
            {
                #region heli body
                new Quad(new Vector3(-0.50f,-0.00f,1.50f),
new Vector3(-0.50f,0.20f,1.50f),
new Vector3(-0.70f,0.20f,1.50f),
new Vector3(-0.70f,-0.00f,1.50f)
,""),

new Quad(new Vector3(-1.00f,0.60f,-0.50f),
new Vector3(-1.00f,2.60f,-0.50f),
new Vector3(1.00f,2.60f,-0.50f),
new Vector3(1.00f,0.60f,-0.50f)
,""),

new Quad(new Vector3(-0.70f,-0.00f,1.50f),
new Vector3(-0.70f,0.20f,1.50f),
new Vector3(-0.70f,0.20f,-0.50f),
new Vector3(-0.70f,0.00f,-0.50f)
,""),

new Quad(new Vector3(-1.00f,2.60f,0.50f),
new Vector3(1.00f,2.60f,0.50f),
new Vector3(1.00f,2.60f,-0.50f),
new Vector3(-1.00f,2.60f,-0.50f)
,""),

new Quad(new Vector3(-0.50f,0.20f,-0.30f),
new Vector3(-0.70f,0.20f,-0.30f),
new Vector3(-0.70f,0.60f,-0.30f),
new Vector3(-0.50f,0.60f,-0.30f)
,""),

new Quad(new Vector3(-0.70f,0.00f,-0.50f),
new Vector3(-0.70f,0.20f,-0.50f),
new Vector3(-0.50f,0.20f,-0.50f),
new Vector3(-0.50f,0.00f,-0.50f)
,""),

new Quad(new Vector3(-0.50f,0.00f,-0.50f),
new Vector3(-0.50f,-0.00f,1.50f),
new Vector3(-0.70f,-0.00f,1.50f),
new Vector3(-0.70f,0.00f,-0.50f)
,""),

new Quad(new Vector3(-0.50f,-0.00f,1.50f),
new Vector3(-0.50f,0.00f,-0.50f),
new Vector3(-0.50f,0.20f,-0.50f),
new Vector3(-0.50f,0.20f,1.50f)
,""),

new Quad(new Vector3(-0.50f,0.20f,1.50f),
new Vector3(-0.50f,0.20f,-0.50f),
new Vector3(-0.70f,0.20f,-0.50f),
new Vector3(-0.70f,0.20f,1.50f)
,""),

new Quad(new Vector3(-0.70f,0.20f,1.00f),
new Vector3(-0.70f,0.20f,1.30f),
new Vector3(-0.70f,0.60f,1.30f),
new Vector3(-0.70f,0.60f,1.00f)
,""),

new Quad(new Vector3(-0.09f,0.62f,-3.50f),
new Vector3(-0.09f,1.58f,-3.50f),
new Vector3(0.09f,1.58f,-3.50f),
new Vector3(0.09f,0.62f,-3.50f)
,""),

new Quad(new Vector3(0.30f,0.80f,-0.50f),
new Vector3(-0.30f,0.80f,-0.50f),
new Vector3(-0.09f,0.80f,-2.50f),
new Vector3(0.09f,0.80f,-2.50f)
,""),

new Quad(new Vector3(-0.30f,0.80f,-0.50f),
new Vector3(-0.30f,1.40f,-0.50f),
new Vector3(-0.09f,1.40f,-2.50f),
new Vector3(-0.09f,0.80f,-2.50f)
,""),

new Quad(new Vector3(-0.50f,0.20f,1.00f),
new Vector3(-0.70f,0.20f,1.00f),
new Vector3(-0.70f,0.60f,1.00f),
new Vector3(-0.50f,0.60f,1.00f)
,""),

new Quad(new Vector3(-0.50f,0.20f,-0.00f),
new Vector3(-0.50f,0.20f,-0.30f),
new Vector3(-0.50f,0.60f,-0.30f),
new Vector3(-0.50f,0.60f,-0.00f)
,""),

new Quad(new Vector3(-0.70f,0.20f,-0.30f),
new Vector3(-0.70f,0.20f,-0.00f),
new Vector3(-0.70f,0.60f,-0.00f),
new Vector3(-0.70f,0.60f,-0.30f)
,""),

new Quad(new Vector3(-0.50f,0.20f,1.30f),
new Vector3(-0.50f,0.20f,1.00f),
new Vector3(-0.50f,0.60f,1.00f),
new Vector3(-0.50f,0.60f,1.30f)
,""),

new Quad(new Vector3(-0.70f,0.20f,-0.00f),
new Vector3(-0.50f,0.20f,-0.00f),
new Vector3(-0.50f,0.60f,-0.00f),
new Vector3(-0.70f,0.60f,-0.00f)
,""),

new Quad(new Vector3(-0.70f,0.20f,1.30f),
new Vector3(-0.50f,0.20f,1.30f),
new Vector3(-0.50f,0.60f,1.30f),
new Vector3(-0.70f,0.60f,1.30f)
,""),

new Quad(new Vector3(1.00f,0.60f,1.50f),
new Vector3(1.00f,1.50f,1.50f),
new Vector3(-1.00f,1.50f,1.50f),
new Vector3(-1.00f,0.60f,1.50f)
,""),

new Quad(new Vector3(1.00f,0.60f,1.50f),
new Vector3(-1.00f,0.60f,1.50f),
new Vector3(-1.00f,0.60f,-0.50f),
new Vector3(1.00f,0.60f,-0.50f)
,""),

new Quad(new Vector3(-0.09f,1.58f,-2.50f),
new Vector3(0.09f,1.58f,-2.50f),
new Vector3(0.09f,1.58f,-3.50f),
new Vector3(-0.09f,1.58f,-3.50f)
,""),

new Quad(new Vector3(-0.09f,0.62f,-2.50f),
new Vector3(0.09f,0.62f,-2.50f),
new Vector3(0.09f,1.58f,-2.50f),
new Vector3(-0.09f,1.58f,-2.50f)
,""),

new Quad(new Vector3(-0.30f,1.40f,-0.50f),
new Vector3(0.30f,1.40f,-0.50f),
new Vector3(0.09f,1.40f,-2.50f),
new Vector3(-0.09f,1.40f,-2.50f)
,""),

new Quad(new Vector3(-0.09f,0.80f,-3.30f),
new Vector3(-0.09f,0.80f,-2.70f),
new Vector3(0.00f,0.80f,-2.70f),
new Vector3(0.00f,0.80f,-3.30f)
,""),

new Quad(new Vector3(0.09f,0.62f,-2.50f),
new Vector3(-0.09f,0.62f,-2.50f),
new Vector3(-0.09f,0.62f,-3.50f),
new Vector3(0.09f,0.62f,-3.50f)
,""),

new Quad(new Vector3(-0.09f,1.40f,-2.70f),
new Vector3(-0.09f,0.80f,-2.70f),
new Vector3(-0.09f,0.62f,-2.50f),
new Vector3(-0.09f,1.58f,-2.50f)
,""),

new Quad(new Vector3(-0.09f,0.80f,-3.30f),
new Vector3(-0.09f,1.40f,-3.30f),
new Vector3(-0.09f,1.58f,-3.50f),
new Vector3(-0.09f,0.62f,-3.50f)
,""),

new Quad(new Vector3(-0.09f,0.80f,-2.70f),
new Vector3(-0.09f,0.80f,-3.30f),
new Vector3(-0.09f,0.62f,-3.50f),
new Vector3(-0.09f,0.62f,-2.50f)
,""),

new Quad(new Vector3(-0.09f,1.40f,-3.30f),
new Vector3(-0.09f,1.40f,-2.70f),
new Vector3(-0.09f,1.58f,-2.50f),
new Vector3(-0.09f,1.58f,-3.50f)
,""),

new Quad(new Vector3(-0.09f,0.80f,-2.70f),
new Vector3(-0.09f,1.40f,-2.70f),
new Vector3(0.00f,1.40f,-2.70f),
new Vector3(0.00f,0.80f,-2.70f)
,""),

new Quad(new Vector3(-0.09f,1.40f,-2.70f),
new Vector3(-0.09f,1.40f,-3.30f),
new Vector3(0.00f,1.40f,-3.30f),
new Vector3(0.00f,1.40f,-2.70f)
,""),

new Quad(new Vector3(-0.09f,1.40f,-3.30f),
new Vector3(-0.09f,0.80f,-3.30f),
new Vector3(0.00f,0.80f,-3.30f),
new Vector3(0.00f,1.40f,-3.30f)
,""),

new Quad(new Vector3(0.50f,-0.00f,1.50f),
new Vector3(0.70f,-0.00f,1.50f),
new Vector3(0.70f,0.20f,1.50f),
new Vector3(0.50f,0.20f,1.50f)
,""),

new Quad(new Vector3(0.70f,-0.00f,1.50f),
new Vector3(0.70f,0.00f,-0.50f),
new Vector3(0.70f,0.20f,-0.50f),
new Vector3(0.70f,0.20f,1.50f)
,""),

new Quad(new Vector3(0.50f,0.20f,-0.30f),
new Vector3(0.50f,0.60f,-0.30f),
new Vector3(0.70f,0.60f,-0.30f),
new Vector3(0.70f,0.20f,-0.30f)
,""),

new Quad(new Vector3(0.70f,0.00f,-0.50f),
new Vector3(0.50f,0.00f,-0.50f),
new Vector3(0.50f,0.20f,-0.50f),
new Vector3(0.70f,0.20f,-0.50f)
,""),

new Quad(new Vector3(0.50f,0.00f,-0.50f),
new Vector3(0.70f,0.00f,-0.50f),
new Vector3(0.70f,-0.00f,1.50f),
new Vector3(0.50f,-0.00f,1.50f)
,""),

new Quad(new Vector3(0.50f,-0.00f,1.50f),
new Vector3(0.50f,0.20f,1.50f),
new Vector3(0.50f,0.20f,-0.50f),
new Vector3(0.50f,0.00f,-0.50f)
,""),

new Quad(new Vector3(0.50f,0.20f,1.50f),
new Vector3(0.70f,0.20f,1.50f),
new Vector3(0.70f,0.20f,-0.50f),
new Vector3(0.50f,0.20f,-0.50f)
,""),

new Quad(new Vector3(0.70f,0.20f,1.00f),
new Vector3(0.70f,0.60f,1.00f),
new Vector3(0.70f,0.60f,1.30f),
new Vector3(0.70f,0.20f,1.30f)
,""),

new Quad(new Vector3(0.30f,0.80f,-0.50f),
new Vector3(0.09f,0.80f,-2.50f),
new Vector3(0.09f,1.40f,-2.50f),
new Vector3(0.30f,1.40f,-0.50f)
,""),

new Quad(new Vector3(0.50f,0.20f,1.00f),
new Vector3(0.50f,0.60f,1.00f),
new Vector3(0.70f,0.60f,1.00f),
new Vector3(0.70f,0.20f,1.00f)
,""),

new Quad(new Vector3(0.50f,0.20f,0.00f),
new Vector3(0.50f,0.60f,0.00f),
new Vector3(0.50f,0.60f,-0.30f),
new Vector3(0.50f,0.20f,-0.30f)
,""),

new Quad(new Vector3(0.70f,0.20f,-0.30f),
new Vector3(0.70f,0.60f,-0.30f),
new Vector3(0.70f,0.60f,0.00f),
new Vector3(0.70f,0.20f,0.00f)
,""),

new Quad(new Vector3(0.50f,0.20f,1.30f),
new Vector3(0.50f,0.60f,1.30f),
new Vector3(0.50f,0.60f,1.00f),
new Vector3(0.50f,0.20f,1.00f)
,""),

new Quad(new Vector3(0.70f,0.20f,0.00f),
new Vector3(0.70f,0.60f,0.00f),
new Vector3(0.50f,0.60f,0.00f),
new Vector3(0.50f,0.20f,0.00f)
,""),

new Quad(new Vector3(0.70f,0.20f,1.30f),
new Vector3(0.70f,0.60f,1.30f),
new Vector3(0.50f,0.60f,1.30f),
new Vector3(0.50f,0.20f,1.30f)
,""),

new Quad(new Vector3(0.09f,0.80f,-3.30f),
new Vector3(0.00f,0.80f,-3.30f),
new Vector3(0.00f,0.80f,-2.70f),
new Vector3(0.09f,0.80f,-2.70f)
,""),

new Quad(new Vector3(0.09f,1.40f,-2.70f),
new Vector3(0.09f,1.58f,-2.50f),
new Vector3(0.09f,0.62f,-2.50f),
new Vector3(0.09f,0.80f,-2.70f)
,""),

new Quad(new Vector3(0.09f,0.80f,-3.30f),
new Vector3(0.09f,0.62f,-3.50f),
new Vector3(0.09f,1.58f,-3.50f),
new Vector3(0.09f,1.40f,-3.30f)
,""),

new Quad(new Vector3(0.09f,0.80f,-2.70f),
new Vector3(0.09f,0.62f,-2.50f),
new Vector3(0.09f,0.62f,-3.50f),
new Vector3(0.09f,0.80f,-3.30f)
,""),

new Quad(new Vector3(0.09f,1.40f,-3.30f),
new Vector3(0.09f,1.58f,-3.50f),
new Vector3(0.09f,1.58f,-2.50f),
new Vector3(0.09f,1.40f,-2.70f)
,""),

new Quad(new Vector3(0.09f,0.80f,-2.70f),
new Vector3(0.00f,0.80f,-2.70f),
new Vector3(0.00f,1.40f,-2.70f),
new Vector3(0.09f,1.40f,-2.70f)
,""),

new Quad(new Vector3(0.09f,1.40f,-2.70f),
new Vector3(0.00f,1.40f,-2.70f),
new Vector3(0.00f,1.40f,-3.30f),
new Vector3(0.09f,1.40f,-3.30f)
,""),

new Quad(new Vector3(0.09f,1.40f,-3.30f),
new Vector3(0.00f,1.40f,-3.30f),
new Vector3(0.00f,0.80f,-3.30f),
new Vector3(0.09f,0.80f,-3.30f)
,""),

new Quad(new Vector3(-1.00f,0.60f,-0.50f),
new Vector3(-1.00f,0.60f,1.50f),
new Vector3(-1.00f,1.50f,1.50f),
new Vector3(-1.00f,1.50f,-0.50f)
,""),

new Quad(new Vector3(1.00f,1.50f,1.50f),
new Vector3(1.00f,0.60f,1.50f),
new Vector3(1.00f,0.60f,-0.50f),
new Vector3(1.00f,1.50f,-0.50f)
,""),
                #endregion
            };

            List<Quad> glass = new List<Quad>
            {
                #region glass
                new Quad(new Vector3(-1.00f,1.50f,1.50f),
new Vector3(-1.00f,2.60f,0.50f),
new Vector3(-1.00f,2.60f,-0.50f),
new Vector3(-1.00f,1.50f,-0.50f)
,@"Texture\vidro"),

new Quad(new Vector3(1.00f,2.60f,0.50f),
new Vector3(-1.00f,2.60f,0.50f),
new Vector3(-1.00f,1.50f,1.50f),
new Vector3(1.00f,1.50f,1.50f)
,@"Texture\vidro"),

new Quad(new Vector3(1.00f,2.60f,-0.50f),
new Vector3(1.00f,2.60f,0.50f),
new Vector3(1.00f,1.50f,1.50f),
new Vector3(1.00f,1.50f,-0.50f)
,@"Texture\vidro"),
                #endregion
            };

            List<Quad> heliMainBlade = new List<Quad>
            {
                #region main blade
                new Quad(new Vector3(0.06f,0.10f,0.06f),
new Vector3(0.06f,0.10f,-0.06f),
new Vector3(0.06f,0.20f,-0.06f),
new Vector3(0.06f,0.20f,0.06f)
,@"Texture\blade"),

new Quad(new Vector3(-0.06f,-0.00f,-0.06f),
new Vector3(-0.06f,0.10f,-0.06f),
new Vector3(0.06f,0.10f,-0.06f),
new Vector3(0.06f,-0.00f,-0.06f)
,@"Texture\blade"),

new Quad(new Vector3(-0.06f,-0.00f,0.06f),
new Vector3(-0.06f,0.10f,0.06f),
new Vector3(-0.06f,0.10f,-0.06f),
new Vector3(-0.06f,-0.00f,-0.06f)
,@"Texture\blade"),

new Quad(new Vector3(0.06f,-0.00f,0.06f),
new Vector3(0.06f,0.10f,0.06f),
new Vector3(-0.06f,0.10f,0.06f),
new Vector3(-0.06f,-0.00f,0.06f)
,@"Texture\blade"),

new Quad(new Vector3(0.06f,-0.00f,-0.06f),
new Vector3(0.06f,0.10f,-0.06f),
new Vector3(0.06f,0.10f,0.06f),
new Vector3(0.06f,-0.00f,0.06f)
,@"Texture\blade"),

new Quad(new Vector3(-0.06f,0.20f,0.06f),
new Vector3(0.06f,0.20f,0.06f),
new Vector3(0.06f,0.20f,-0.06f),
new Vector3(-0.06f,0.20f,-0.06f)
,@"Texture\blade"),

new Quad(new Vector3(0.06f,0.10f,-0.06f),
new Vector3(-0.06f,0.10f,-0.06f),
new Vector3(-0.06f,0.20f,-0.06f),
new Vector3(0.06f,0.20f,-0.06f)
,@"Texture\blade"),

new Quad(new Vector3(-0.06f,0.10f,0.06f),
new Vector3(0.06f,0.10f,0.06f),
new Vector3(0.06f,0.20f,0.06f),
new Vector3(-0.06f,0.20f,0.06f)
,@"Texture\blade"),

new Quad(new Vector3(-0.06f,0.10f,-0.06f),
new Vector3(-0.06f,0.10f,0.06f),
new Vector3(-0.06f,0.20f,0.06f),
new Vector3(-0.06f,0.20f,-0.06f)
,@"Texture\blade"),

new Quad(new Vector3(-0.06f,0.10f,0.06f),
new Vector3(-0.06f,0.10f,-0.06f),
new Vector3(-3.00f,0.10f,-0.15f),
new Vector3(-3.00f,0.10f,0.15f)
,@"Texture\blade"),

new Quad(new Vector3(-0.15f,0.10f,-3.00f),
new Vector3(-0.06f,0.10f,-0.06f),
new Vector3(0.06f,0.10f,-0.06f),
new Vector3(0.15f,0.10f,-3.00f)
,@"Texture\blade"),

new Quad(new Vector3(0.06f,0.10f,-0.06f),
new Vector3(0.06f,0.10f,0.06f),
new Vector3(3.00f,0.10f,0.15f),
new Vector3(3.00f,0.10f,-0.15f)
,@"Texture\blade"),

new Quad(new Vector3(0.15f,0.10f,3.00f),
new Vector3(0.06f,0.10f,0.06f),
new Vector3(-0.06f,0.10f,0.06f),
new Vector3(-0.15f,0.10f,3.00f)
,@"Texture\blade"),
                #endregion
            };

            List<Quad> heliTailBlade = new List<Quad>()
            {
                #region tail blade
                new Quad(new Vector3(-0.03f,0.02f,-0.02f),
new Vector3(-0.03f,0.02f,0.02f),
new Vector3(-0.03f,0.20f,0.04f),
new Vector3(-0.03f,0.20f,-0.04f)
,@"Texture\blade"),

new Quad(new Vector3(-0.03f,-0.02f,-0.02f),
new Vector3(-0.03f,0.02f,-0.02f),
new Vector3(-0.03f,0.04f,-0.20f),
new Vector3(-0.03f,-0.04f,-0.20f)
,@"Texture\blade"),

new Quad(new Vector3(0.00f,0.02f,0.02f),
new Vector3(0.00f,-0.02f,0.02f),
new Vector3(0.00f,-0.02f,-0.02f),
new Vector3(0.00f,0.02f,-0.02f)
,@"Texture\blade"),

new Quad(new Vector3(-0.03f,0.02f,0.02f),
new Vector3(-0.03f,0.02f,-0.02f),
new Vector3(-0.06f,0.02f,-0.02f),
new Vector3(-0.06f,0.02f,0.02f)
,@"Texture\blade"),

new Quad(new Vector3(0.00f,-0.02f,-0.02f),
new Vector3(-0.03f,-0.02f,-0.02f),
new Vector3(-0.03f,0.02f,-0.02f),
new Vector3(0.00f,0.02f,-0.02f)
,@"Texture\blade"),

new Quad(new Vector3(0.00f,-0.02f,0.02f),
new Vector3(-0.03f,-0.02f,0.02f),
new Vector3(-0.03f,-0.02f,-0.02f),
new Vector3(0.00f,-0.02f,-0.02f)
,@"Texture\blade"),

new Quad(new Vector3(0.00f,0.02f,0.02f),
new Vector3(-0.03f,0.02f,0.02f),
new Vector3(-0.03f,-0.02f,0.02f),
new Vector3(0.00f,-0.02f,0.02f)
,@"Texture\blade"),

new Quad(new Vector3(0.00f,0.02f,-0.02f),
new Vector3(-0.03f,0.02f,-0.02f),
new Vector3(-0.03f,0.02f,0.02f),
new Vector3(0.00f,0.02f,0.02f)
,@"Texture\blade"),

new Quad(new Vector3(-0.03f,-0.02f,0.02f),
new Vector3(-0.03f,-0.02f,-0.02f),
new Vector3(-0.03f,-0.20f,-0.04f),
new Vector3(-0.03f,-0.20f,0.04f)
,@"Texture\blade"),

new Quad(new Vector3(-0.03f,-0.02f,0.02f),
new Vector3(-0.03f,0.02f,0.02f),
new Vector3(-0.03f,0.04f,0.20f),
new Vector3(-0.03f,-0.04f,0.20f)
,@"Texture\blade"),

new Quad(new Vector3(-0.06f,-0.02f,0.02f),
new Vector3(-0.06f,0.02f,0.02f),
new Vector3(-0.06f,0.02f,-0.02f),
new Vector3(-0.06f,-0.02f,-0.02f)
,@"Texture\blade"),

new Quad(new Vector3(-0.03f,0.02f,-0.02f),
new Vector3(-0.03f,-0.02f,-0.02f),
new Vector3(-0.06f,-0.02f,-0.02f),
new Vector3(-0.06f,0.02f,-0.02f)
,@"Texture\blade"),

new Quad(new Vector3(-0.03f,-0.02f,0.02f),
new Vector3(-0.03f,0.02f,0.02f),
new Vector3(-0.06f,0.02f,0.02f),
new Vector3(-0.06f,-0.02f,0.02f)
,@"Texture\blade"),

new Quad(new Vector3(-0.03f,-0.02f,-0.02f),
new Vector3(-0.03f,-0.02f,0.02f),
new Vector3(-0.06f,-0.02f,0.02f),
new Vector3(-0.06f,-0.02f,-0.02f)
,@"Texture\blade"),
                #endregion
            };
            chooper.AddQuads(heliBody); // adicionar a lista de poligonos
            chooper.AddQuads(glass);
            chooper.SetPosition(0,  1.5f, 0.5f); // setar posicao do helicoptero
            chooper.SetMainBlade(0, 4.1f, 0.5f, heliMainBlade); // adicionar helices e setar posicoes
            chooper.SetTailBlade(0, 2.6f, -2.5f, heliTailBlade); 
            #endregion


            Obj casa = new Obj(@"Texture\Wall");
            #region set da casa
            List<Quad> parede = new List<Quad>
            {
                #region paredes
                new Quad(new Vector3(-1.50f,1.00f,2.75f),
new Vector3(-1.50f,1.00f,0.75f),
new Vector3(-1.50f,0.00f,0.75f),
new Vector3(-1.50f,0.00f,2.75f)
,@"Texture\wall"),

new Quad(new Vector3(-1.50f,3.00f,-3.75f),
new Vector3(-1.50f,2.00f,-3.75f),
new Vector3(-1.50f,2.00f,3.75f),
new Vector3(-1.50f,3.00f,3.75f)
,@"Texture\wall"),

new Quad(new Vector3(-1.50f,2.00f,-1.10f),
new Vector3(-1.50f,1.30f,-1.10f),
new Vector3(-1.50f,1.30f,0.75f),
new Vector3(-1.50f,2.00f,0.75f)
,@"Texture\wall"),

new Quad(new Vector3(-1.50f,0.00f,-3.75f),
new Vector3(-1.50f,3.00f,-3.75f),
new Vector3(1.30f,3.00f,-3.75f),
new Vector3(1.30f,0.00f,-3.75f)
,@"Texture\wall"),

new Quad(new Vector3(-1.50f,1.30f,-1.80f),
new Vector3(-1.50f,2.00f,-1.80f),
new Vector3(-1.50f,2.00f,-3.75f),
new Vector3(-1.50f,1.30f,-3.75f)
,@"Texture\wall"),

new Quad(new Vector3(-1.50f,2.00f,3.75f),
new Vector3(-1.50f,2.00f,2.75f),
new Vector3(-1.50f,0.00f,2.75f),
new Vector3(-1.50f,0.00f,3.75f)
,@"Texture\wall"),

new Quad(new Vector3(-1.50f,1.30f,0.75f),
new Vector3(-1.50f,1.30f,-3.75f),
new Vector3(-1.50f,0.00f,-3.75f),
new Vector3(-1.50f,0.00f,0.75f)
,@"Texture\wall"),

new Quad(new Vector3(0.51f,2.00f,3.75f),
new Vector3(0.51f,0.00f,3.75f),
new Vector3(1.30f,0.00f,3.75f),
new Vector3(1.30f,2.00f,3.75f)
,@"Texture\wall"),

new Quad(new Vector3(1.30f,3.00f,3.75f),
new Vector3(-1.50f,3.00f,3.75f),
new Vector3(-1.50f,2.00f,3.75f),
new Vector3(1.30f,2.00f,3.75f)
,@"Texture\wall"),

new Quad(new Vector3(-1.50f,0.00f,3.75f),
new Vector3(-0.79f,0.00f,3.75f),
new Vector3(-0.79f,1.99f,3.75f),
new Vector3(-1.50f,2.00f,3.75f)
,@"Texture\wall"),

new Quad(new Vector3(1.30f,1.80f,1.40f),
new Vector3(1.30f,1.80f,-1.10f),
new Vector3(1.30f,2.00f,-1.10f),
new Vector3(1.30f,2.00f,1.40f)
,@"Texture\wall"),

new Quad(new Vector3(1.30f,1.80f,1.40f),
new Vector3(1.30f,0.00f,1.40f),
new Vector3(1.30f,0.00f,-1.80f),
new Vector3(1.30f,1.80f,-1.80f)
,@"Texture\wall"),

new Quad(new Vector3(1.30f,0.00f,2.10f),
new Vector3(1.30f,0.00f,1.40f),
new Vector3(1.30f,1.30f,1.40f),
new Vector3(1.30f,1.30f,2.10f)
,@"Texture\wall"),

new Quad(new Vector3(1.30f,2.00f,-1.80f),
new Vector3(1.30f,0.00f,-1.80f),
new Vector3(1.30f,0.00f,-3.75f),
new Vector3(1.30f,2.00f,-3.75f)
,@"Texture\wall"),

new Quad(new Vector3(1.30f,3.00f,3.75f),
new Vector3(1.30f,2.00f,3.75f),
new Vector3(1.30f,2.00f,-3.75f),
new Vector3(1.30f,3.00f,-3.75f)
,@"Texture\wall"),

new Quad(new Vector3(1.30f,2.00f,2.10f),
new Vector3(1.30f,2.00f,3.75f),
new Vector3(1.30f,0.00f,3.75f),
new Vector3(1.30f,0.00f,2.10f)
,@"Texture\wall"),


                #endregion
            };
            Quad teto = new Quad(new Vector3(1.30f, 3.00f, -3.75f),
            new Vector3(-1.50f, 3.00f, -3.75f),
            new Vector3(-1.50f, 3.00f, 3.75f),
            new Vector3(1.30f, 3.00f, 3.75f)
            , @"Texture\helo");

            List<Quad> misc = new List<Quad>
            {
                #region misc
		new Quad(new Vector3(1.30f,1.80f,-1.10f),
new Vector3(1.30f,1.80f,-1.80f),
new Vector3(1.30f,2.00f,-1.80f),
new Vector3(1.30f,2.00f,-1.10f)
,@"Texture\wood"),

new Quad(new Vector3(1.30f,1.30f,2.10f),
new Vector3(1.30f,1.30f,1.40f),
new Vector3(1.30f,2.00f,1.40f),
new Vector3(1.30f,2.00f,2.10f)
,@"Texture\wood"),

new Quad(new Vector3(-1.50f,2.00f,1.75f),
new Vector3(-1.50f,2.00f,0.75f),
new Vector3(-1.50f,1.00f,0.75f),
new Vector3(-1.50f,1.00f,1.75f)
,@"Texture\wood"),

new Quad(new Vector3(-1.50f,2.00f,-1.80f),
new Vector3(-1.50f,1.30f,-1.80f),
new Vector3(-1.50f,1.30f,-1.10f),
new Vector3(-1.50f,2.00f,-1.10f)
,@"Texture\wood"),

new Quad(new Vector3(-1.50f,1.00f,1.75f),
new Vector3(-1.50f,1.00f,2.75f),
new Vector3(-1.50f,2.00f,2.75f),
new Vector3(-1.50f,2.00f,1.75f)
,@"Texture\wood"),

new Quad(new Vector3(-0.79f,1.99f,3.75f),
new Vector3(-0.79f,-0.01f,3.75f),
new Vector3(0.51f,-0.01f,3.75f),
new Vector3(0.51f,1.99f,3.75f)
,@"Texture\wood"), 
	#endregion
            };
            #endregion
            parede.Add(teto);
            casa.AddQuads(misc);
            casa.AddQuads(parede);
            casa.SetPosition(0, -1.5f, 0);
            
            Obj chao = new Obj(@"Texture\Ground",
            #region set do chao
            new List<Quad> 
                    { 
                        new Quad(
                            new Vector3(8.5f,0,-9),
                            new Vector3(8.5f,0,9),
                            new Vector3(-8.5f,0,9),
                            new Vector3(-8.5f,0,-9),"")
                    }
                );
            chao.SetPosition(0, -1.6f, 0);
            chao.Rotate(Vector3.Up, MathHelper.ToRadians(180));
            #endregion
            
            //TODO: Create sets
            //TODO: Include objects on set
            List<Obj> pimba = new List<Obj> 
            {
                chooper,
                chao,
                casa
            };

            //TODO: Create scenes
            //TODO: Insert the set of objects on scene
            actualScene = new Scene(pimba, "Cena 1");

            //TODO: add the scences
            scenes = new List<Scene>();
            scenes.Add(actualScene);
        }

        public static void Update(GameTime gameTime)
        {
            //TODO: Logic to update a scene
            actualScene.Update(gameTime);
        }

        public static void Draw()
        {
            //TODO: Logic to draw a scene
            actualScene.Draw(camera);
        }
    }
}
