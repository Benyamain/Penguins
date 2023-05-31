using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.MLAgents;
using Unity.MLAgents.Actuators;
using Unity.MLAgents.Sensors;

public class PenguinAgent : Agent
{
    // How fast the agent moves forward
    public float moveSpeed = 5f;
    // How fast the agent turns
    public float turnSpeed = 180f;
    // Heart prefab that appears when the baby is fed
    public GameObject heartPrefab;
    // Regurgitated fish prefab that appears when the baby is fed
    public GameObject regurgitatedFishPrefab;
    
    private PenguinArea penguinArea;
    new private Rigidbody rigidbody;
    private GameObject baby;
    // Depicts if the penguin has a full stomach
    private bool isFull;

    // When the agent wakes up (enables), not when it resets
    public override void Initialize() {
        base.Initialize();
        penguinArea = GetComponentInParent<PenguinArea>();
        baby = penguinArea.penguinBaby;
        rigidbody = GetComponent<Rigidbody>();
    }

    // When the agent receives and responds to commands. These commands can originate from a neural network or a human player
    // actionBuffers is a struct that contains an array of numerical values that correspond to actions the agent should take
    // Discrete indicates that each numerical value corresponds to a singular action
    // DiscreteActions[0]: 0 or 1 ; 0 to remain in place and 1 to move forward at full speed
    // DiscreteActions[1]: 0, 1, 2 ; 0 to not turn, 1 to turn in the negative direction, and 2 to turn in the positive direction
    // However, neural network has no concept of what these actions do. All it does know that some actions tend to result in more reward points
    // Applies movement, rotation, and adds a small negative reward. The reward encourages the agent to complete its task ASAP
    // Application example: -(steps / 5000). Longer it takes the agent, bigger the (-) value

    // Performs actions based on vector of numbers
    public override void OnActionReceived(ActionBuffers actionBuffers) {
        // Con
    }
}
