using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Spawner : MonoBehaviour, IPointerDownHandler
{
    [SerializeField] private List<GameObject> _prefabs;

    public void OnPointerDown(PointerEventData eventData)
    {
        if(_prefabs.Count != 0)
        {
            Transform spawnedObject = Instantiate(_prefabs[0], transform).transform;
            spawnedObject.position = eventData.position;
            _prefabs.RemoveAt(0);
        }
    }
}
