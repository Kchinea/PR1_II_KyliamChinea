# PR1_II_KyliamChinea
En esta practica se busca realizar una escena con el editor de unity a modo de introducción, los requisitos serían:
- Incluir objetos 3D básicos
- Incluir  en el proyecto el paquete Starter Assets.
- Incluir un objeto libre de la Asset Store que no sea de los Starter Assets.
- Crear un terreno.
- Cada objeto debe tener una etiqueta que lo identifique.
- Utilizar prefabs de Starter Asset FPS o Third Person.
- Agregar un script que escriba en la consola la etiqueta y posición de cada objeto que hayas utilizado. 

# Pasos realizados

## Creación del terreno
- Se generó un Terreno desde el editor de Unity.  
- Se aplicaron texturas realistas usando un asset de la Asset Store especializado en terrenos.

## Importación de Starter Assets
- Se importó el paquete **Starter Assets – Third Person** para disponer de un personaje jugable en tercera persona.  
- Se añadió el prefab del **NestdParentArmature_Unpack** dentro de la escena.

## Añadido de objetos 3D básicos
- Se añadieron objetos simples de Unity (como cubos, esferas, planos), son **torres 3D** (4 en total) como elementos destacados en la escena.

## Uso de un asset libre de la Asset Store
- Se descargaron e incorporaron cajas, casas y troncos de un asset gratuito de la Asset Store (distinto a los Starter Assets).  
- Se añadieron las texturas del terreno para enriquecer la ambientación de la escena.

## Etiquetas (Tags)
- Cada objeto de la escena recibió un **Tag** personalizado que lo identifica (por ejemplo: `Tower`, `Person`, `Floor`, `ligth`).

## Creación de script en C#
- Se implementó un script que:
  - Recorre todos los objetos de la escena.
  - Muestra en la consola de Unity el nombre de la **etiqueta (Tag)** y la posición (`Transform.position`) de cada objeto cuando su tag sea distinta de `Untagged`.

```csharp
using UnityEngine;
public class PrintObjectsInfo : MonoBehaviour
{
    void Start()
    {
        GameObject[] allObjects = FindObjectsOfType<GameObject>();
        foreach (GameObject obj in allObjects)
        {
            if (obj.tag != "Untagged")
            {
                Debug.Log($"Objeto: {obj.name} | Tag: {obj.tag} | Posición: {obj.transform.position}");
            }
        }
    }
}
```
# Demostración

![Ejecución del script](Video_PR1_II-GIF.gif)
