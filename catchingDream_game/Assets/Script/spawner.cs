﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
	public GameObject[] obstaclePatterns;
	// public GameObject obstacle;

	private float timeBtwSpawn;
	public float startTimeBtwSpawn;
	public float decreaseTime;
	public float minTime = 0.65f;
	private int rand;
	private int sebelumnya = -1;

	private void Start()
    {
		sebelumnya = -1;
    }
	
	private void Update()
	{
		if(timeBtwSpawn <= 0)
		{
			int rand = Random.Range(0, obstaclePatterns.Length);
			if(rand == sebelumnya)
            {
				rand = Random.Range(sebelumnya + 1, obstaclePatterns.Length);
			}	
			Instantiate(obstaclePatterns[rand], transform.position, Quaternion.identity);
			// Instantiate(obstacle, transform.position, Quaternion.identity);
			timeBtwSpawn = startTimeBtwSpawn;
			if(startTimeBtwSpawn > minTime)
			{
				startTimeBtwSpawn -= decreaseTime;
			}
			sebelumnya = rand;
		} 
		else
		{
			timeBtwSpawn -= Time.deltaTime;
		}
	}
}