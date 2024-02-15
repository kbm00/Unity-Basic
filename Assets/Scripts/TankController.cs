
using Cinemachine;
using UnityEngine;
using UnityEngine.InputSystem;

public class TankController : MonoBehaviour
{
    public Rigidbody rigid;
    public Transform headTransform;
    public Transform firePoint;
    public Bullet bulletPrefab;


    public float movePower;
    public float rotateSpeed;
    public float bulletForce;
    public float maxSpeed;

    private Vector3 moveDir;
    private Vector3 headDir;

    public CinemachineVirtualCamera nomalCamera;
    public CinemachineVirtualCamera zoomCamera;

    public AudioSource shootSound;

    public Animator animator;

    private void Update()
    {
        Rotate();
        Head();
    }

    private void FixedUpdate()
    {
        Move();
    }
    private void OnFire(InputValue value)
    {
        if (value.isPressed)
        {
            Fire();
        }
    }
    public void Fire()
    {
        Bullet bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        bullet.force = bulletForce;
        shootSound.Play();
        animator.SetTrigger("Fire");
        


    }


    private void Move()
    {
        Vector3 forceDir = transform.forward * moveDir.z;
        rigid.AddForce(forceDir * movePower, ForceMode.Force);

        if (rigid.velocity.magnitude > maxSpeed)
        {
            rigid.velocity = rigid.velocity.normalized * maxSpeed;
        }
        // transform.Translate(0, 0, moveDir.z * moveSpeed * Time.deltaTime, Space.Self);
    }

    private void Rotate()
    {
        transform.Rotate(Vector3.up, moveDir.x * rotateSpeed * Time.deltaTime, Space.World);
    }

    private void Head()
    {
        headTransform.Rotate(Vector3.right, -headDir.y * rotateSpeed * Time.deltaTime, Space.Self);
        headTransform.Rotate(Vector3.up, headDir.x * rotateSpeed * Time.deltaTime, Space.World);
    }


    private void OnMove(InputValue value)
    {
        Vector2 inputDir = value.Get<Vector2>();
        moveDir.x = inputDir.x;
        moveDir.z = inputDir.y;
    }



    private void OnHead(InputValue value)
    {
        Vector2 inputDir = value.Get<Vector2>();
        headDir.x = inputDir.x;
        headDir.y = inputDir.y;
    }

    private void OnZoom(InputValue value)
    {
        if (value.isPressed)
        {

            zoomCamera.Priority = 50;
        }
        else
        {
            zoomCamera.Priority = 1;
        }
    }
}



