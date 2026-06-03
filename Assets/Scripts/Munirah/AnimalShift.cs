using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimalShift : MonoBehaviour
{
    public GameObject raccoonModel;
    public GameObject tigerModel;
    public GameObject crocodileModel;
    public GameObject zebraModel;

    public AnimalType currentAnimal = AnimalType.Raccoon;

    private List<AnimalType> unlockedAnimals = new();

    private int currentIndex = 0;

    private void Start()
    {
        unlockedAnimals.Add(AnimalType.Raccoon);

        UpdateModel();
    }

    public void Shift()
    {
        if (unlockedAnimals.Count <= 1)
            return;

        currentIndex++;

        if (currentIndex >= unlockedAnimals.Count)
            currentIndex = 0;

        currentAnimal = unlockedAnimals[currentIndex];

        UpdateModel();
    }
    
    public void UnlockAnimal(AnimalType animal)
    {
        if (!unlockedAnimals.Contains(animal))
        {
            unlockedAnimals.Add(animal);
            Debug.Log(animal + " unlocked!");
        }
    }
   
    private void UpdateModel()
    {
        raccoonModel.SetActive(false);
        tigerModel.SetActive(false);
        crocodileModel.SetActive(false);
        zebraModel.SetActive(false);
       

        switch (currentAnimal)
        {
            case AnimalType.Raccoon:
                raccoonModel.SetActive(true);
                break;

            case AnimalType.Tiger:
                tigerModel.SetActive(true);
                break;

            case AnimalType.Crocodile:
                crocodileModel.SetActive(true);
                break;

            case AnimalType.zebra:
                zebraModel.SetActive(true);
                break;
        }
    }

    public void OnShift(InputValue value)
    {
        
            Shift();
      
    }
    
}
