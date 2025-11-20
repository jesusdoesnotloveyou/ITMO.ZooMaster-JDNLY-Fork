using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private Net _net;
    [SerializeField] private Animator _animator;
    [SerializeField] private AudioClip selected;
    [SerializeField] private AudioClip badClip;
    [SerializeField] private AudioClip goodClip;
    [SerializeField] private string selectedTrigger = "bounce";
    [SerializeField] private string badTrigger = "munch";
    [SerializeField] private string goodTrigger = "spin";

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (_net)
        {
        _net.BadClick += OnBadClickEvent;
        _net.BadTry += OnBadTryEvent;
        _net.GoodClick += OnGoodClickEvent;
        _net.AnimalsMoving += OnAnimalsMovingEvent;
        _net.AnimalsChanged += OnAnimalsChangedEvent;
        _net.Selected += OnSelectedEvent;
        }

        if (!_animator)
        {
            _animator = GetComponent<Animator>();
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnSelectedEvent()
    {
        _animator.SetTrigger(selectedTrigger);
    }
    void OnBadClickEvent() 
    {
        _animator.SetTrigger(badTrigger);
    }
    void OnAnimalsMovingEvent()
    {
        _animator.SetTrigger(goodTrigger);
    }

    void OnBadTryEvent()
    {

    }

    void OnGoodClickEvent() 
    {
    
    }


    void OnAnimalsChangedEvent(int number)
    {

    }
}
