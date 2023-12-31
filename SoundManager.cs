﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;

namespace Asteroid_Belt_Assault
{
     public static class SoundManager
    {
         private static List<SoundEffect> explosions = new List<SoundEffect>();
         private static int explosionCount = 4;
         private static SoundEffect playerShot;
         private static SoundEffect enemyShot;
         private static Random rand = new Random();

         public static void Initialize(ContentManager content)
         {
             try
             {
                 playerShot = content.Load<SoundEffect>(@"Sounds\Shot1");
                 enemyShot = content.Load<SoundEffect>(@"Sounds\Shot2");
                 for (int x = 1; x <= explosionCount; x++)
                 {
                     explosions.Add(content.Load<SoundEffect>(@"Sounds\Explosion" + x.ToString()));
                 }
             }
             catch (Exception)
             {
                 Debug.Write("SoundManager Initialization Failed");
                 
                 throw;
             }
         }

         public static void PlayExplosion()
         {
             try
             {
                 explosions[rand.Next(0, explosionCount)].Play();
             }
             catch (Exception)
             {
                 Debug.Write("PlayExplosion Failed");

                 throw;
             }
         }

         public static void PlayPlayerShot()
         {
             try
             {
                 playerShot.Play();
             }
             catch (Exception)
             {
                 Debug.Write("PlayPlayerShot Failed");

                 throw;
             }
         }

         public static void PlayEEnemyShot()
         {
             try
             {
                 enemyShot.Play();
             }
             catch (Exception)
             {
                 Debug.Write("PlayEnemyShot Failed");

                 throw;
             }
         }
    }
}
