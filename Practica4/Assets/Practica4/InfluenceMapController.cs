﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace es.ucm.fdi.iav.rts
{
    public class InfluenceMapController : MonoBehaviour
    {
        public Transform bottomLeftPoint;
        public Transform topRightPoint;

        public float gridDim;
        public float decay = 0.3f;
        public float momentum = 0.1f;

        InfluenceMap mMap;

        void Start()
        {
            int width = (int)(Mathf.Abs(topRightPoint.position.x - bottomLeftPoint.position.x) / gridDim);
            int height = (int)(Mathf.Abs(topRightPoint.position.z - bottomLeftPoint.position.z) / gridDim);
    
            mMap = gameObject.GetComponent<InfluenceMap>();
            mMap.setDimension(width, height);
            Debug.Log(width + " " + height);
            mMap.Decay = decay;
            mMap.Momentum = momentum;


        }

        public void UpdateMap(int player1, int player2)
        {
            // Hacemos la actualización por separado para evitar que el mapa de influencia
            // se distorsione en funcion del orden de procesado
            mMap.UpdateUnits(player1, player2);
            mMap.UpdateMap();

        }

        public Vector2Nodo GetGridPosition(Vector3 pos)
        {
            int x = (int)(Mathf.Abs((pos.x - bottomLeftPoint.position.x) / gridDim));
            int y = (int)(Mathf.Abs((pos.z - bottomLeftPoint.position.z) / gridDim));

            return new Vector2Nodo(x, y);
        }
    }
}