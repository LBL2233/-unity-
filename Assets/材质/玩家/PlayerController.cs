using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public LayerMask layerMask; // ָ�����߼��Ĳ�
    private Vector3 currentLookTarget = Vector3.zero; // ��ǰ�����Ŀ��λ��

    void FixedUpdate()
    {
        // ����������λ�÷���һ������
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        // �ڳ�����ͼ�л������ߣ��������
        Debug.DrawRay(ray.origin, ray.direction * 1000, Color.green);
        // ������ײ��Ϣ
        RaycastHit hit;
        // ���������ָ����������ཻ
        if (Physics.Raycast(ray, out hit, 1000, layerMask, QueryTriggerInteraction.Ignore))
        {
            // ����ཻ�㲻���ڵ�ǰ�����Ŀ��λ��
            if (hit.point != currentLookTarget)
            {
                // ���µ�ǰ�����Ŀ��λ��Ϊ�ཻ��
                currentLookTarget = hit.point;
            }
            // ����һ��Ŀ��λ�ã�����y�����꣬ʹ���ﲻ����б
            Vector3 targetPosition = new Vector3(hit.point.x, transform.position.y, hit.point.z);
            // ����Ŀ��λ�ú�����λ�ü������ת�Ƕ�
            Quaternion rotation = Quaternion.LookRotation(targetPosition - transform.position);
            // ƽ������ת���ʹ�䳯��Ŀ��λ��
            transform.rotation = Quaternion.Lerp(transform.rotation, rotation, Time.deltaTime * 10.0f);
        }
    }
}